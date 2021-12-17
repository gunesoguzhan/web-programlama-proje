using CarRent.Data;
using CarRent.Models;
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

            List<Car> cars = new List<Car>();

            for(int i = 0; i < 2; i++)
            {
                Random rand = new Random(DateTime.Now.Millisecond);
                int toSkip = rand.Next(0, _context.Cars.Count());
                cars.Add(_context.Cars.Include(x => x.Engine).Include(x => x.Office.Address.District.Province).Skip(toSkip).Take(1).FirstOrDefault());
            }
            
            return View(cars);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
