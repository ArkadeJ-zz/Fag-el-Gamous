using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fag_el_Gamous.Models.Filtering.FilteringSample
{
    public class FilterSampleLogic
    {
        private waterbuffaloContext _mummyContext { get; set; }



        public FilterSampleLogic(waterbuffaloContext mummyContext)
        {
            _mummyContext = mummyContext;
        }



        public IQueryable<Samples2> GetSamples(FilterSample searchModel, int pageNum = 1, int pageSize = 10)
        {
            //if you filter by certain things, make sure that only those things that match are displayed
            var result = _mummyContext.Samples2.AsQueryable();
            if (searchModel != null)
            {
                if (!string.IsNullOrEmpty(searchModel.Area))
                {
                    result = result.Where(x => x.Area.Contains(searchModel.Area));
                }
                if (searchModel.RackNum.HasValue)
                {
                    result = result.Where(x => x.RackNum == searchModel.RackNum);
                }
                if (searchModel.DateYear.HasValue)
                {
                    result = result.Where(x => x.DateYear == searchModel.DateYear);
                }

            }

            return result;
        }
    }
}
