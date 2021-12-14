using System;
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
    public class RentDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RentDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RentDetails
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.RentDetails.Include(r => r.Car).Include(r => r.Office);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RentDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentDetails = await _context.RentDetails
                .Include(r => r.Car)
                .Include(r => r.Office)
                .FirstOrDefaultAsync(m => m.RentId == id);
            if (rentDetails == null)
            {
                return NotFound();
            }

            return View(rentDetails);
        }

        // GET: RentDetails/Create
        public IActionResult Create()
        {
            ViewData["CarId"] = new SelectList(_context.Cars, "CarId", "CarBrand");
            ViewData["OfficeId"] = new SelectList(_context.Offices, "OfficeId", "OfficeEmailAddress");
            return View();
        }

        // POST: RentDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RentId,RentDate,TotalPrice,UserId,CarId,OfficeId")] RentDetails rentDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rentDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CarId"] = new SelectList(_context.Cars, "CarId", "CarBrand", rentDetails.CarId);
            ViewData["OfficeId"] = new SelectList(_context.Offices, "OfficeId", "OfficeEmailAddress", rentDetails.OfficeId);
            return View(rentDetails);
        }

        // GET: RentDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentDetails = await _context.RentDetails.FindAsync(id);
            if (rentDetails == null)
            {
                return NotFound();
            }
            ViewData["CarId"] = new SelectList(_context.Cars, "CarId", "CarBrand", rentDetails.CarId);
            ViewData["OfficeId"] = new SelectList(_context.Offices, "OfficeId", "OfficeEmailAddress", rentDetails.OfficeId);
            return View(rentDetails);
        }

        // POST: RentDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RentId,RentDate,TotalPrice,UserId,CarId,OfficeId")] RentDetails rentDetails)
        {
            if (id != rentDetails.RentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentDetailsExists(rentDetails.RentId))
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
            ViewData["CarId"] = new SelectList(_context.Cars, "CarId", "CarBrand", rentDetails.CarId);
            ViewData["OfficeId"] = new SelectList(_context.Offices, "OfficeId", "OfficeEmailAddress", rentDetails.OfficeId);
            return View(rentDetails);
        }

        // GET: RentDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentDetails = await _context.RentDetails
                .Include(r => r.Car)
                .Include(r => r.Office)
                .FirstOrDefaultAsync(m => m.RentId == id);
            if (rentDetails == null)
            {
                return NotFound();
            }

            return View(rentDetails);
        }

        // POST: RentDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rentDetails = await _context.RentDetails.FindAsync(id);
            _context.RentDetails.Remove(rentDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentDetailsExists(int id)
        {
            return _context.RentDetails.Any(e => e.RentId == id);
        }
    }
}
