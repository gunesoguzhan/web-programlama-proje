using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarRent.Data;
using CarRent.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace CarRent.Controllers
{
    public class CarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Car
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Cars.Include(c => c.Engine).Include(c => c.Office.Address.District.Province).Where(x => x.Reservations.Count() == 0 || !x.Reservations.Any(y => y.ReservationStatus == ReservationStatus.reserved));
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Car/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["EngineId"] = new SelectList(_context.Engines, "EngineId", "EngineName");
            ViewData["OfficeId"] = new SelectList(_context.Offices, "OfficeId", "OfficeName");
            return View();
        }

        // POST: Car/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CarId,CarBrand,CarModel,CarType,CarTrimPackage,CarColor,CarProductYear,CarKilometer,CarRentPrice,CarDepositPrice,MinimumAge,CarImageUrl, CarCoverImageUrl,CarTransmissionType,EngineId,OfficeId")] Car car)
        {
            if (ModelState.IsValid)
            {
                _context.Add(car);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListAdmin));
            }
            ViewData["EngineId"] = new SelectList(_context.Engines, "EngineId", "EngineName", car.EngineId);
            ViewData["OfficeId"] = new SelectList(_context.Offices, "OfficeId", "OfficeName", car.OfficeId);
            return View(car);
        }

        // GET: Car/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            ViewData["EngineId"] = new SelectList(_context.Engines, "EngineId", "EngineName", car.EngineId);
            ViewData["OfficeId"] = new SelectList(_context.Offices, "OfficeId", "OfficeEmailAddress", car.OfficeId);
            return View(car);
        }

        // POST: Car/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CarId,CarBrand,CarModel,CarType,CarTrimPackage,CarColor,CarProductYear,CarKilometer,CarRentPrice,CarDepositPrice,MinimumAge,CarImageUrl, CarCoverImageUrl,CarTransmissionType,EngineId,OfficeId")] Car car)
        {
            if (id != car.CarId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(car);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExists(car.CarId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListAdmin));
            }
            ViewData["EngineId"] = new SelectList(_context.Engines, "EngineId", "EngineName", car.EngineId);
            ViewData["OfficeId"] = new SelectList(_context.Offices, "OfficeId", "OfficeEmailAddress", car.OfficeId);
            return View(car);
        }

        // GET: Car/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .Include(c => c.Engine)
                .Include(c => c.Office)
                .FirstOrDefaultAsync(m => m.CarId == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // POST: Car/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListAdmin));
        }

        private bool CarExists(int id)
        {
            return _context.Cars.Any(e => e.CarId == id);
        }

        [HttpPost]
        public IActionResult List()
        {
            string reservationP = HttpContext.Request.Form["RentPlace"].ToString();
            string returnP = HttpContext.Request.Form["ReturnPlace"].ToString();
            string reservationD = HttpContext.Request.Form["RentDate"].ToString();
            string returnD = HttpContext.Request.Form["ReturnDate"].ToString();

            if(string.IsNullOrEmpty(reservationP) || string.IsNullOrEmpty(returnP) || string.IsNullOrEmpty(reservationD) || string.IsNullOrEmpty(returnD))
            {
                return RedirectToAction("Index", "Home");
            }

            int reservationPlace = Convert.ToInt32(reservationP);
            int returnPlace = Convert.ToInt32(returnP);
            DateTime reservationDate = DateTime.ParseExact(reservationD, "yyyy-MM-ddTH:m", System.Globalization.CultureInfo.InvariantCulture);
            DateTime returnDate = DateTime.ParseExact(returnD, "yyyy-MM-ddTH:m", System.Globalization.CultureInfo.InvariantCulture);

            if(reservationDate < DateTime.Now.AddMinutes(5))
            {
                return RedirectToAction("Index", "Home");
            }
            else if(returnDate < reservationDate.AddMinutes(55))
            {
                return RedirectToAction("Index", "Home");
            }

            var returnOffice = _context.Offices.Include(x => x.Address.District.Province).Where(x => x.OfficeId == returnPlace).FirstOrDefault();

            Reservation reservation = new Reservation();
            reservation.ReservationDate = reservationDate;
            reservation.ReturnDate = returnDate;
            reservation.Days = (returnDate - reservationDate).Days;

            if(reservationDate.TimeOfDay < returnDate.TimeOfDay)
            {
                reservation.Days++;
            }

            reservation.ReturnOffice = _context.Offices.Where(x => x.OfficeId == returnPlace).FirstOrDefault();
            HttpContext.Session.SetObject("Reservation", reservation);

            var cars = _context.Cars.Include(x => x.Engine).Include(x => x.Office.Address).Where(x => x.OfficeId == reservationPlace).Where(x=>x.Reservations.Count() == 0 || !x.Reservations.Any(y => y.ReservationStatus == ReservationStatus.reserved)).ToList();
            return View(cars);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ListAdmin()
        {
            var applicationDbContext = _context.Cars.Include(c => c.Engine).Include(c => c.Office);
            return View(await applicationDbContext.ToListAsync());
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DetailsAdmin(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .Include(c => c.Engine)
                .Include(c => c.Office)
                .FirstOrDefaultAsync(m => m.CarId == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }
    }
}
