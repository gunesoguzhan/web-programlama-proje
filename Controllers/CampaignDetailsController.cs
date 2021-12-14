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
    public class CampaignDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CampaignDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CampaignDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.CampaignDetails.ToListAsync());
        }

        // GET: CampaignDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaignDetails = await _context.CampaignDetails
                .FirstOrDefaultAsync(m => m.CampaignDetailsId == id);
            if (campaignDetails == null)
            {
                return NotFound();
            }

            return View(campaignDetails);
        }

        // GET: CampaignDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CampaignDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CampaignDetailsId,CampaignName,CampaignDetail,CampaignDiscount,NumberOfCampaigns,UserId")] CampaignDetails campaignDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(campaignDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(campaignDetails);
        }

        // GET: CampaignDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaignDetails = await _context.CampaignDetails.FindAsync(id);
            if (campaignDetails == null)
            {
                return NotFound();
            }
            return View(campaignDetails);
        }

        // POST: CampaignDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CampaignDetailsId,CampaignName,CampaignDetail,CampaignDiscount,NumberOfCampaigns,UserId")] CampaignDetails campaignDetails)
        {
            if (id != campaignDetails.CampaignDetailsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(campaignDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CampaignDetailsExists(campaignDetails.CampaignDetailsId))
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
            return View(campaignDetails);
        }

        // GET: CampaignDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaignDetails = await _context.CampaignDetails
                .FirstOrDefaultAsync(m => m.CampaignDetailsId == id);
            if (campaignDetails == null)
            {
                return NotFound();
            }

            return View(campaignDetails);
        }

        // POST: CampaignDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var campaignDetails = await _context.CampaignDetails.FindAsync(id);
            _context.CampaignDetails.Remove(campaignDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CampaignDetailsExists(int id)
        {
            return _context.CampaignDetails.Any(e => e.CampaignDetailsId == id);
        }
    }
}
