﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarRent.Data;
using CarRent.Models;

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
            var applicationDbContext = _context.Cars.Include(c => c.Engine).Include(c => c.Office);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Car/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Car/Create
        public IActionResult Create()
        {
            ViewData["EngineId"] = new SelectList(_context.Engines, "EngineId", "EngineName");
            ViewData["OfficeId"] = new SelectList(_context.Offices, "OfficeId", "OfficeEmailAddress");
            return View();
        }

        // POST: Car/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CarId,CarBrand,CarModel,CarType,CarTrimPackage,CarSeats,CarDoors,CarColor,CarProductYear,CarKilometer,CarRentPrice,CarDepositPrice,MinimumAge,CarImageUrl,CarTransmissionType,EngineId,OfficeId")] Car car)
        {
            if (ModelState.IsValid)
            {
                _context.Add(car);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EngineId"] = new SelectList(_context.Engines, "EngineId", "EngineName", car.EngineId);
            ViewData["OfficeId"] = new SelectList(_context.Offices, "OfficeId", "OfficeEmailAddress", car.OfficeId);
            return View(car);
        }

        // GET: Car/Edit/5
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
        public async Task<IActionResult> Edit(int id, [Bind("CarId,CarBrand,CarModel,CarType,CarTrimPackage,CarSeats,CarDoors,CarColor,CarProductYear,CarKilometer,CarRentPrice,CarDepositPrice,MinimumAge,CarImageUrl,CarTransmissionType,EngineId,OfficeId")] Car car)
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
                return RedirectToAction(nameof(Index));
            }
            ViewData["EngineId"] = new SelectList(_context.Engines, "EngineId", "EngineName", car.EngineId);
            ViewData["OfficeId"] = new SelectList(_context.Offices, "OfficeId", "OfficeEmailAddress", car.OfficeId);
            return View(car);
        }

        // GET: Car/Delete/5
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
            return RedirectToAction(nameof(Index));
        }

        private bool CarExists(int id)
        {
            return _context.Cars.Any(e => e.CarId == id);
        }

        [HttpGet]
        public IActionResult List()
        {
            string rentP = HttpContext.Request.Query["RentPlace"].ToString();
            string returnP = HttpContext.Request.Query["ReturnPlace"].ToString();
            string rentD = HttpContext.Request.Query["RentDate"].ToString();
            string returnD = HttpContext.Request.Query["ReturnDate"].ToString();

            if (string.IsNullOrEmpty(rentP) || string.IsNullOrEmpty(returnP) || string.IsNullOrEmpty(rentD) || string.IsNullOrEmpty(returnD))
            {
                return RedirectToAction("Index", "Home");
            }

            int rentPlace = Convert.ToInt32(rentP);
            int returnPlace = Convert.ToInt32(returnP);
            DateTime rentDate = DateTime.ParseExact(rentD, "yyyy-MM-ddTH:m", System.Globalization.CultureInfo.InvariantCulture);
            DateTime returnDate = DateTime.ParseExact(returnD, "yyyy-MM-ddTH:m", System.Globalization.CultureInfo.InvariantCulture);

            var cars = _context.Cars.Include(x => x.Engine).Include(x => x.Office).Where(x => x.OfficeId == rentPlace);

            return View(cars);
        }
    }
}
