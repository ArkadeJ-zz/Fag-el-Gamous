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
            ViewBag.LocConcat = RouteData?.Values["LocConcat"];

            return View(_context.MasterBurial2
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
