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
    public class UserStatisticDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserStatisticDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserStatisticDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserStatisticDetails.ToListAsync());
        }

        // GET: UserStatisticDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userStatisticDetails = await _context.UserStatisticDetails
                .FirstOrDefaultAsync(m => m.StaticticsId == id);
            if (userStatisticDetails == null)
            {
                return NotFound();
            }

            return View(userStatisticDetails);
        }

        // GET: UserStatisticDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserStatisticDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StaticticsId,NumberOfRent,TotalRentTime,YearOfRegister,UserId")] UserStatisticDetails userStatisticDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userStatisticDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userStatisticDetails);
        }

        // GET: UserStatisticDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userStatisticDetails = await _context.UserStatisticDetails.FindAsync(id);
            if (userStatisticDetails == null)
            {
                return NotFound();
            }
            return View(userStatisticDetails);
        }

        // POST: UserStatisticDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StaticticsId,NumberOfRent,TotalRentTime,YearOfRegister,UserId")] UserStatisticDetails userStatisticDetails)
        {
            if (id != userStatisticDetails.StaticticsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userStatisticDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserStatisticDetailsExists(userStatisticDetails.StaticticsId))
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
            return View(userStatisticDetails);
        }

        // GET: UserStatisticDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userStatisticDetails = await _context.UserStatisticDetails
                .FirstOrDefaultAsync(m => m.StaticticsId == id);
            if (userStatisticDetails == null)
            {
                return NotFound();
            }

            return View(userStatisticDetails);
        }

        // POST: UserStatisticDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userStatisticDetails = await _context.UserStatisticDetails.FindAsync(id);
            _context.UserStatisticDetails.Remove(userStatisticDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserStatisticDetailsExists(int id)
        {
            return _context.UserStatisticDetails.Any(e => e.StaticticsId == id);
        }
    }
}
