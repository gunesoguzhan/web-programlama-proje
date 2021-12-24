using CarRent.Data;
using CarRent.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var provinceDistrict = (from province in _context.Provinces
                                    from district in _context.Districts
                                    where province.ProvinceId == district.ProvinceId
                                    select new
                                    {
                                        DistrictId = district.DistrictId,
                                        ProvinceDistrict = province.ProvinceName + " - " + district.DistrictName
                                    }).ToList();
            ViewData["ProvinceDistrict"] = new SelectList(provinceDistrict, "DistrictId", "ProvinceDistrict");

            List<Car> cars = _context.Cars.Include(x => x.Engine).Include(x => x.Office.Address.District.Province).Where(x => x.Reservations.Count() == 0 || !x.Reservations.Any(y => y.ReservationStatus == ReservationStatus.reserved)).ToList();

            //for(int i = 0; i < 2; i++)
            //{
            //    Random rand = new Random(DateTime.Now.Millisecond);
            //    int toSkip = rand.Next(0, _context.Cars.Count());
            //    cars.Add(_context.Cars.Include(x => x.Engine).Include(x => x.Office.Address.District.Province).Where(x => x.Reservation == null || x.Reservation.ReservationStatus == ReservationStatus.complated).Skip(toSkip).Take(1).FirstOrDefault());
            //}

            ViewData["Cars"] = cars;

            return View();
        }

        public IActionResult En()
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture("en-US")),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddMonths(1) }
            );

            return RedirectToAction("Index");
        }

        public IActionResult Tr()
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture("tr-TR")),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddMonths(1) }
            );

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
