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
using Fag_el_Gamous.Models.Filtering.FilteringCarbon;

namespace Fag_el_Gamous.Controllers
{
    public class Carbon2Controller : Controller
    {
        private readonly waterbuffaloContext _context;

        public Carbon2Controller(waterbuffaloContext context)
        {
            _context = context;
        }

        // GET: Carbon2
        
        public async Task<IActionResult> Index(FilterCarbon filter, int? carbonId, int pageNum = 1)
        {
            //variable of type FilterCarbonLogic
            var filterCarbonLogic = new FilterCarbonLogic(_context);

            //queryModel that is the return from the GetCarbons method
            var queryModel = filterCarbonLogic.GetCarbons(filter);
            
            //creates a list of Burial with Burial IDs (so we can link them in the view)
            ViewBag.MasterBurialList = _context.MasterBurial2
                .Where(c => c.BurialId != null)
                .ToList();

            //creates a list of Carbons with Burial IDs (so we can link them in the view)
            ViewBag.CarbonBurialList = _context.Carbon2
                .Where(c => c.BurialId != null)
                .ToList();

            //Checks to see if user is admin
            var isAdmin = _context.AspNetUsers
                .Where(c => c.UserName == User.Identity.Name);

            foreach(var thing in isAdmin)
            {
                if( thing.isAdmin == true )
                {
                    ViewData["isAdmin"] = true;
                }
            }

            //Checks to see if user is researcher
            var isResearcher = _context.AspNetUsers
                .Where(c => c.UserName == User.Identity.Name);

            foreach (var thing in isResearcher)
            {
                if (thing.isResearcher == true)
                {
                    ViewData["isResearcher"] = true;
                }
            }

            //increased to send more pages to the jQuery Table
            int pageSize = 10000;

            int skip = 0;

            if (pageNum - 1 < 0)
            { skip = 0; }
            else
            {
                skip = (pageNum - 1) * pageSize;
            }

            return View(new PaginationViewModel
            {
                //Carbons = ((IQueryable<Carbon2>)_context.Carbon2.Include(c => c.Burial).ToListAsync()),

            Carbons = (queryModel
                    .Skip(skip)
                    .Take(pageSize)
                    .ToList()),

                PageNumberingInfo = new PageNumberingInfo
                {
                    NumItemsPerPage = pageSize,
                    CurrentPage = pageNum,

                    TotalNumItems = (carbonId == null ? queryModel.Count() :
                        queryModel.Where(x => x.CarbonId == carbonId).Count())
                },

                //used for pagination while filtering
                UrlInfo = Request.QueryString.Value
            });

        }

        // GET: Carbon2/Details/5
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carbon2 = await _context.Carbon2
                .Include(c => c.Burial)
                .FirstOrDefaultAsync(m => m.CarbonId == id);
            if (carbon2 == null)
            {
                return NotFound();
            }

            return View(carbon2);
        }

        // GET: Carbon2/Create
        [Authorize]
        public IActionResult Create()
        {
            //check to see if user is admin
            var isAdmin = _context.AspNetUsers
                .Where(c => c.UserName == User.Identity.Name);

            foreach(var thing in isAdmin)
            {
                if( thing.isAdmin == true )
                {
                    ViewData["isAdmin"] = true;
                }
            }

            //Check to see if user is researcher
            var isResearcher = _context.AspNetUsers
                .Where(c => c.UserName == User.Identity.Name);

            foreach (var thing in isResearcher)
            {
                if (thing.isResearcher == true)
                {
                    ViewData["isResearcher"] = true;
                }
            }


            ViewData["BurialId"] = new SelectList(_context.MasterBurial2, "BurialId", "BurialId");
            return View();
        }

        // POST: Carbon2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CarbonId,BurialId,LocConcat,RackNum,LocationNs,Ns,LocationEw,Ew,BurialSubplot,Area,BurialNum,RackAlt,TubeNum,Description,SizeMl,Foci,C14Sample2017,Location,Questions,Num,Conventional14cAgeBp,CCalendarDate,Calibrated95PercentCalendarDateMax,Calibrated95PercentCalendarDateMin,Calibrated95PercentCalendarDateSpan,Calibrated95PercentCalendarDateAvg,Category,Notes")] Carbon2 carbon2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carbon2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BurialId"] = new SelectList(_context.MasterBurial2, "BurialId", "BurialId", carbon2.BurialId);
            return View(carbon2);
        }

        // GET: Carbon2/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            //check to see if user is admin
            var isAdmin = _context.AspNetUsers
                .Where(c => c.UserName == User.Identity.Name);

            foreach(var thing in isAdmin)
            {
                if( thing.isAdmin == true )
                {
                    ViewData["isAdmin"] = true;
                }
            }

            //check to see if user is researcher
            var isResearcher = _context.AspNetUsers
                .Where(c => c.UserName == User.Identity.Name);

            foreach (var thing in isResearcher)
            {
                if (thing.isResearcher == true)
                {
                    ViewData["isResearcher"] = true;
                }
            }

            if (id == null)
            {
                return NotFound();
            }

            var carbon2 = await _context.Carbon2.FindAsync(id);
            if (carbon2 == null)
            {
                return NotFound();
            }
            ViewData["BurialId"] = new SelectList(_context.MasterBurial2, "BurialId", "BurialId", carbon2.BurialId);
            return View(carbon2);
        }

        // POST: Carbon2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CarbonId,BurialId,LocConcat,RackNum,LocationNs,Ns,LocationEw,Ew,BurialSubplot,Area,BurialNum,RackAlt,TubeNum,Description,SizeMl,Foci,C14Sample2017,Location,Questions,Num,Conventional14cAgeBp,CCalendarDate,Calibrated95PercentCalendarDateMax,Calibrated95PercentCalendarDateMin,Calibrated95PercentCalendarDateSpan,Calibrated95PercentCalendarDateAvg,Category,Notes")] Carbon2 carbon2)
        {
            if (id != carbon2.CarbonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carbon2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Carbon2Exists(carbon2.CarbonId))
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
            ViewData["BurialId"] = new SelectList(_context.MasterBurial2, "BurialId", "BurialId", carbon2.BurialId);
            return View(carbon2);
        }

        // GET: Carbon2/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            //Check to see if user is admin
            var isAdmin = _context.AspNetUsers
                .Where(c => c.UserName == User.Identity.Name);

            foreach(var thing in isAdmin)
            {
                if( thing.isAdmin == true )
                {
                    ViewData["isAdmin"] = true;
                }
            }

            //Check to see if user is researcher
            var isResearcher = _context.AspNetUsers
                .Where(c => c.UserName == User.Identity.Name);

            foreach (var thing in isResearcher)
            {
                if (thing.isResearcher == true)
                {
                    ViewData["isResearcher"] = true;
                }
            }

            if (id == null)
            {
                return NotFound();
            }

            var carbon2 = await _context.Carbon2
                .Include(c => c.Burial)
                .FirstOrDefaultAsync(m => m.CarbonId == id);
            if (carbon2 == null)
            {
                return NotFound();
            }

            return View(carbon2);
        }

        // POST: Carbon2/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carbon2 = await _context.Carbon2.FindAsync(id);
            _context.Carbon2.Remove(carbon2);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Carbon2Exists(int id)
        {
            return _context.Carbon2.Any(e => e.CarbonId == id);
        }
    }
}
