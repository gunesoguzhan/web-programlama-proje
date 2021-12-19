using CarRent.Data;
using CarRent.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CarRent.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "User")]
        public IActionResult Reservations()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var reservation = _context.Reservations.Include(x => x.Car.Engine).Include(x => x.Car.Office.Address.District.Province).Include(x => x.ReturnOffice.Address.District.Province).Where(x => x.UserId == userId).Where(x => x.ReservationStatus == ReservationStatus.reserved).FirstOrDefault();
            return View(reservation);
        }
    }
}
