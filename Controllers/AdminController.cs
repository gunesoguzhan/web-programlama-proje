using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Controllers
{
    // [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult User()
        {
            return View();
        }

        public IActionResult Car()
        {
            return View();
        }

        public IActionResult Office()
        {
            return View();
        }

        public IActionResult Address()
        {
            return View();
        }

        public IActionResult Campaign()
        {
            return View();
        }
    }
}
