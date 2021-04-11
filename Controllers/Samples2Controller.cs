using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fag_el_Gamous.Models;
using Fag_el_Gamous.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Fag_el_Gamous.Controllers
{
    public class Samples2Controller : Controller
    {
        private readonly waterbuffaloContext _context;

        public Samples2Controller(waterbuffaloContext context)
        {
            _context = context;
        }

        // GET: Samples2

        public async Task<IActionResult> Index(int? sampleId, int pageNum = 0)
        {
            int pageSize = 100;

            int skip = 0;

            if (pageNum - 1 < 0)
            { skip = 0; }
            else
            {
                skip = (pageNum - 1) * pageSize;
            }

            return View(new PaginationViewModel
            {

                Samples = (_context.Samples2
                    .Where(c => c.SampleId == sampleId || sampleId == null)
                    .Skip(skip)
                    .Take(pageSize)
                    .ToList()),

                PageNumberingInfo = new PageNumberingInfo
                {
                    NumItemsPerPage = pageSize,
                    CurrentPage = pageNum,

                    TotalNumItems = (sampleId == null ? _context.Samples2.Count() :
                        _context.Samples2.Where(x => x.SampleId == sampleId).Count())
                }
            });


            //var waterbuffaloContext = _context.Samples2.Include(s => s.Burial);
            //return View(await waterbuffaloContext.ToListAsync());
        }

        // GET: Samples2/Details/5
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var samples2 = await _context.Samples2
                .Include(s => s.Burial)
                .FirstOrDefaultAsync(m => m.SampleId == id);
            if (samples2 == null)
            {
                return NotFound();
            }

            return View(samples2);
        }

        // GET: Samples2/Create
        [HttpGet]
        [Authorize]
        public IActionResult Create(int Id)
        {
            ViewData["BurialId"] = new SelectList(_context.MasterBurial2, "BurialId", "BurialId");
            return View();
        }

        // POST: Samples2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SampleId,BurialId,LocConcat,RackNum,BagNum,LowNs,HighNs,NS,LowEw,HighEw,EW,Area,BurialNum,SubBurialNum,ClusterNum,DateDay,DateMonth,DateYear,PreviouslySampled,Notes,Initials")] Samples2 samples2)
        {
            if (ModelState.IsValid)
            {
                //samples2.BurialId = ViewBag.Id;
                _context.Add(samples2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BurialId"] = new SelectList(_context.MasterBurial2, "BurialId", "BurialId", samples2.BurialId);
            return View(samples2);
        }

        // GET: Samples2/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var samples2 = await _context.Samples2.FindAsync(id);
            if (samples2 == null)
            {
                return NotFound();
            }
            ViewData["BurialId"] = new SelectList(_context.MasterBurial2, "BurialId", "BurialId", samples2.BurialId);
            return View(samples2);
        }

        // POST: Samples2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SampleId,BurialId,LocConcat,RackNum,BagNum,LowNs,HighNs,NS,LowEw,HighEw,EW,Area,BurialNum,SubBurialNum,ClusterNum,DateDay,DateMonth,DateYear,PreviouslySampled,Notes,Initials")] Samples2 samples2)
        {
            if (id != samples2.SampleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(samples2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Samples2Exists(samples2.SampleId))
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
            ViewData["BurialId"] = new SelectList(_context.MasterBurial2, "BurialId", "BurialId", samples2.BurialId);
            return View(samples2);
        }

        // GET: Samples2/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var samples2 = await _context.Samples2
                .Include(s => s.Burial)
                .FirstOrDefaultAsync(m => m.SampleId == id);
            if (samples2 == null)
            {
                return NotFound();
            }

            return View(samples2);
        }

        // POST: Samples2/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var samples2 = await _context.Samples2.FindAsync(id);
            _context.Samples2.Remove(samples2);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Samples2Exists(int id)
        {
            return _context.Samples2.Any(e => e.SampleId == id);
        }
    }
}
