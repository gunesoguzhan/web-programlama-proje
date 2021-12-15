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
    public class OfficeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OfficeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Office
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Offices.Include(o => o.Address);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Office/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var office = await _context.Offices
                .Include(o => o.Address)
                .FirstOrDefaultAsync(m => m.OfficeId == id);
            if (office == null)
            {
                return NotFound();
            }

            return View(office);
        }

        // GET: Office/Create
        public IActionResult Create()
        {
            ViewData["AddressId"] = new SelectList(_context.Addresses, "AddressId", "AddressTitle");
            return View();
        }

        // POST: Office/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OfficeId,OfficeName,OfficePhone,OfficeEmailAddress,AddressId")] Office office)
        {
            if (ModelState.IsValid)
            {
                _context.Add(office);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddressId"] = new SelectList(_context.Addresses, "AddressId", "AddressTitle", office.AddressId);
            return View(office);
        }

        // GET: Office/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var office = await _context.Offices.FindAsync(id);
            if (office == null)
            {
                return NotFound();
            }
            ViewData["AddressId"] = new SelectList(_context.Addresses, "AddressId", "AddressTitle", office.AddressId);
            return View(office);
        }

        // POST: Office/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OfficeId,OfficeName,OfficePhone,OfficeEmailAddress,AddressId")] Office office)
        {
            if (id != office.OfficeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(office);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OfficeExists(office.OfficeId))
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
            ViewData["AddressId"] = new SelectList(_context.Addresses, "AddressId", "AddressTitle", office.AddressId);
            return View(office);
        }

        // GET: Office/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var office = await _context.Offices
                .Include(o => o.Address)
                .FirstOrDefaultAsync(m => m.OfficeId == id);
            if (office == null)
            {
                return NotFound();
            }

            return View(office);
        }

        // POST: Office/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var office = await _context.Offices.FindAsync(id);
            _context.Offices.Remove(office);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OfficeExists(int id)
        {
            return _context.Offices.Any(e => e.OfficeId == id);
        }
    }
}
