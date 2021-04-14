using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fag_el_Gamous.Models.Filtering.FilteringCarbon
{
    public class FilterCarbonLogic
    {
        private waterbuffaloContext _mummyContext { get; set; }



        public FilterCarbonLogic(waterbuffaloContext mummyContext)
        {
            _mummyContext = mummyContext;
        }



        public IQueryable<Carbon2> GetCarbons(FilterCarbon searchModel, int pageNum = 1, int pageSize = 10)
        {
            //if you filter by certain things, make sure that only those things that match are displayed
            var result = _mummyContext.Carbon2.AsQueryable();
            if (searchModel != null)
            {
                if (!string.IsNullOrEmpty(searchModel.BurialSubplot))
                {
                    result = result.Where(x => x.BurialSubplot.Contains(searchModel.BurialSubplot));
                }
                if (!string.IsNullOrEmpty(searchModel.RackNum))
                {
                    result = result.Where(x => x.RackNum == searchModel.RackNum);
                }

            }

            return result;
        }
    }
}
