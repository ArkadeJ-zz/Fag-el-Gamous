using Fag_el_Gamous.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fag_el_Gamous.Components
{
    public class FilterViewComponent : ViewComponent 
    {
        private waterbuffaloContext _context;

        public FilterViewComponent (waterbuffaloContext ctx)
        {
            _context = ctx;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.BurialSubPlot = RouteData?.Values["BurialSubPlot"];

            return View(_context.MasterBurial2
                //.Where(x => x.BurialSubplot == ViewBag.BurialSubPlot || ViewBag.BurialSubPlot == null)
                .Distinct()
                .OrderBy(x => x)
                .ToList());
        }
    }
}
