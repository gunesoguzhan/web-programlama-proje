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
    public class ReturnDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReturnDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ReturnDetails
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ReturnDetails.Include(r => r.Office).Include(r => r.RentDetails);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ReturnDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var returnDetails = await _context.ReturnDetails
                .Include(r => r.Office)
                .Include(r => r.RentDetails)
                .FirstOrDefaultAsync(m => m.ReturnId == id);
            if (returnDetails == null)
            {
                return NotFound();
            }

            return View(returnDetails);
        }

        // GET: ReturnDetails/Create
        public IActionResult Create()
        {
            ViewData["OfficeId"] = new SelectList(_context.Offices, "OfficeId", "OfficeEmailAddress");
            ViewData["RentId"] = new SelectList(_context.RentDetails, "RentId", "RentId");
            return View();
        }

        // POST: ReturnDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReturnId,ReturnDate,RentId,OfficeId")] ReturnDetails returnDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(returnDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OfficeId"] = new SelectList(_context.Offices, "OfficeId", "OfficeEmailAddress", returnDetails.OfficeId);
            ViewData["RentId"] = new SelectList(_context.RentDetails, "RentId", "RentId", returnDetails.RentId);
            return View(returnDetails);
        }

        // GET: ReturnDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var returnDetails = await _context.ReturnDetails.FindAsync(id);
            if (returnDetails == null)
            {
                return NotFound();
            }
            ViewData["OfficeId"] = new SelectList(_context.Offices, "OfficeId", "OfficeEmailAddress", returnDetails.OfficeId);
            ViewData["RentId"] = new SelectList(_context.RentDetails, "RentId", "RentId", returnDetails.RentId);
            return View(returnDetails);
        }

        // POST: ReturnDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReturnId,ReturnDate,RentId,OfficeId")] ReturnDetails returnDetails)
        {
            if (id != returnDetails.ReturnId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(returnDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReturnDetailsExists(returnDetails.ReturnId))
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
            ViewData["OfficeId"] = new SelectList(_context.Offices, "OfficeId", "OfficeEmailAddress", returnDetails.OfficeId);
            ViewData["RentId"] = new SelectList(_context.RentDetails, "RentId", "RentId", returnDetails.RentId);
            return View(returnDetails);
        }

        // GET: ReturnDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var returnDetails = await _context.ReturnDetails
                .Include(r => r.Office)
                .Include(r => r.RentDetails)
                .FirstOrDefaultAsync(m => m.ReturnId == id);
            if (returnDetails == null)
            {
                return NotFound();
            }

            return View(returnDetails);
        }

        // POST: ReturnDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var returnDetails = await _context.ReturnDetails.FindAsync(id);
            _context.ReturnDetails.Remove(returnDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReturnDetailsExists(int id)
        {
            return _context.ReturnDetails.Any(e => e.ReturnId == id);
        }
    }
}
