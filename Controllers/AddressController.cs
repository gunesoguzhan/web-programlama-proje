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
    public class AddressController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AddressController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Address
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Addresses.Include(a => a.District.Province.Country);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Address/Create
        public IActionResult Create()
        {
            var provinceDistrict = (from province in _context.Provinces
                                    from district in _context.Districts
                                    where province.ProvinceId == district.ProvinceId
                                    select new
                                    {
                                        DistrictId = district.DistrictId,
                                        ProvinceDistrict = province.ProvinceName + " - " + district.DistrictName
                                    }).ToList();
            ViewData["DistrictId"] = new SelectList(provinceDistrict, "DistrictId", "ProvinceDistrict");
            return View();
        }

        // POST: Address/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AddressId,AddressTitle,AddressText,DistrictId")] Address address)
        {
            if (ModelState.IsValid)
            {
                _context.Add(address);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            var provinceDistrict = (from province in _context.Provinces
                                    from district in _context.Districts
                                    where province.ProvinceId == district.ProvinceId
                                    select new
                                    {
                                        DistrictId = district.DistrictId,
                                        ProvinceDistrict = province.ProvinceName + " - " + district.DistrictName
                                    }).ToList();
            ViewData["DistrictId"] = new SelectList(provinceDistrict, "DistrictId", "ProvinceDistrict");
            return View(address);
        }

        // GET: Address/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var address = await _context.Addresses.FindAsync(id);
            if (address == null)
            {
                return NotFound();
            }
            var provinceDistrict = (from province in _context.Provinces
                                    from district in _context.Districts
                                    where province.ProvinceId == district.ProvinceId
                                    select new
                                    {
                                        DistrictId = district.DistrictId,
                                        ProvinceDistrict = province.ProvinceName + " - " + district.DistrictName
                                    }).ToList();
            ViewData["DistrictId"] = new SelectList(provinceDistrict, "DistrictId", "ProvinceDistrict");
            return View(address);
        }

        // POST: Address/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AddressId,AddressTitle,AddressText,DistrictId")] Address address)
        {
            if (id != address.AddressId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(address);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddressExists(address.AddressId))
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
            var provinceDistrict = (from province in _context.Provinces
                                    from district in _context.Districts
                                    where province.ProvinceId == district.ProvinceId
                                    select new
                                    {
                                        DistrictId = district.DistrictId,
                                        ProvinceDistrict = province.ProvinceName + " - " + district.DistrictName
                                    }).ToList();
            ViewData["DistrictId"] = new SelectList(provinceDistrict, "DistrictId", "ProvinceDistrict");
            return View(address);
        }

        // GET: Address/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var address = await _context.Addresses
                .Include(a => a.District.Province.Country)
                .FirstOrDefaultAsync(m => m.AddressId == id);
            if (address == null)
            {
                return NotFound();
            }

            return View(address);
        }

        // POST: Address/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var address = await _context.Addresses.FindAsync(id);
            _context.Addresses.Remove(address);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddressExists(int id)
        {
            return _context.Addresses.Any(e => e.AddressId == id);
        }
    }
}
