using CarRent.Data;
using CarRent.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CarRent.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservationController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "User")]
        public IActionResult Details(int id)
        {
            Reservation reservation = HttpContext.Session.GetObject<Reservation>("Reservation");

            if (reservation == null)
            {
                return NotFound();
            }

            reservation.UserId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            HttpContext.Session.SetObject("Reservation", reservation);
            return View(reservation);
        }

        public IActionResult Reserve(int id)
        {
            Car car = _context.Cars.Include(x => x.Engine).Include(x => x.Office.Address.District.Province).Where(x => x.CarId == id).FirstOrDefault();

            Reservation reservation = HttpContext.Session.GetObject<Reservation>("Reservation");
            
            if(reservation == null)
            {
                return NotFound();
            }

            reservation.Car = car;
            reservation.TotalPrice = (reservation.Days * reservation.Car.CarRentPrice) + reservation.Car.CarDepositPrice;
            HttpContext.Session.SetObject("Reservation", reservation);

            return RedirectToAction("Details");
        }

        public IActionResult FastReservation(int id)
        {
            Car car = _context.Cars.Include(x => x.Office.Address.District.Province).Include(x => x.Engine).Where(x => x.CarId == id).FirstOrDefault();

            if(car == null)
            {
                return NotFound();
            }

            Reservation reservation = new Reservation();
            reservation.Car = car;
            HttpContext.Session.SetObject("Reservation", reservation);

            var provinceDistrict = (from province in _context.Provinces
                                    from district in _context.Districts
                                    where province.ProvinceId == district.ProvinceId
                                    select new
                                    {
                                        DistrictId = district.DistrictId,
                                        ProvinceDistrict = province.ProvinceName + " - " + district.DistrictName
                                    }).ToList();
            ViewData["ProvinceDistrict"] = new SelectList(provinceDistrict, "DistrictId", "ProvinceDistrict");

            return View(reservation);
        }

        [HttpPost]
        public IActionResult FastReserve()
        {
            string returnP = HttpContext.Request.Form["ReturnPlace"].ToString();
            string rentD = HttpContext.Request.Form["RentDate"].ToString();
            string returnD = HttpContext.Request.Form["ReturnDate"].ToString();

            if (string.IsNullOrEmpty(returnP) || string.IsNullOrEmpty(rentD) || string.IsNullOrEmpty(returnD))
            {
                return RedirectToAction("Index", "Home");
            }

            int returnPlace = Convert.ToInt32(returnP);
            DateTime rentDate = DateTime.ParseExact(rentD, "yyyy-MM-ddTH:m", System.Globalization.CultureInfo.InvariantCulture);
            DateTime returnDate = DateTime.ParseExact(returnD, "yyyy-MM-ddTH:m", System.Globalization.CultureInfo.InvariantCulture);

            if (rentDate < DateTime.Now.AddMinutes(5))
            {
                return RedirectToAction("Index", "Home");
            }
            else if (returnDate < rentDate.AddMinutes(55))
            {
                return RedirectToAction("Index", "Home");
            }

            var returnOffice = _context.Offices.Include(x => x.Address.District.Province).Where(x => x.OfficeId == returnPlace).FirstOrDefault();

            Reservation reservation = HttpContext.Session.GetObject<Reservation>("Reservation");
            reservation.RentDate = rentDate;
            reservation.ReturnDate = returnDate;
            reservation.Days = returnDate.Day - rentDate.Day;

            if (rentDate.TimeOfDay < returnDate.TimeOfDay)
            {
                reservation.Days++;
            }

            reservation.ReturnOffice = _context.Offices.Where(x => x.OfficeId == returnPlace).FirstOrDefault();
            reservation.TotalPrice = (reservation.Days * reservation.Car.CarRentPrice) + reservation.Car.CarDepositPrice;
            HttpContext.Session.SetObject("Reservation", reservation);

            return RedirectToAction("Details");
        }

        public IActionResult Payment()
        {
            if(HttpContext.Session.GetObject<Reservation>("Reservation") == null)
            {
                return NotFound();
            }

            return View();
        }

        public IActionResult Complated()
        {
            Reservation reservation = HttpContext.Session.GetObject<Reservation>("Reservation");

            if (reservation == null)
            {
                return NotFound();
            }

            _context.Entry(reservation).State = EntityState.Modified;

            _context.Add(reservation);
            _context.SaveChanges();

            return View(reservation);
        }
    }
}
