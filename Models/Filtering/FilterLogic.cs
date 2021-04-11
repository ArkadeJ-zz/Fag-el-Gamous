using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fag_el_Gamous.Models;
using Fag_el_Gamous.Models.ViewModels;

namespace Fag_el_Gamous.Models.Filtering
{
    public class FilterLogic
    {
        private waterbuffaloContext _mummyContext { get; set; }



        public FilterLogic(waterbuffaloContext mummyContext)
        {
            _mummyContext = mummyContext;
        }



        public IQueryable<MasterBurial2> GetMummies(Filter searchModel, int pageNum = 1, int pageSize = 10)
        {

            var result = _mummyContext.MasterBurial2.AsQueryable();
            if (searchModel != null)
            {
                if (!string.IsNullOrEmpty(searchModel.BurialSubPlot))
                {
                    result = result.Where(x => x.BurialSubplot.Contains(searchModel.BurialSubPlot));
                }
                if (!string.IsNullOrEmpty(searchModel.Sex))
                {
                    result = result.Where(x => x.Sex.Contains(searchModel.Sex));
                }
                if (!string.IsNullOrEmpty(searchModel.HairColor))
                {
                    result = result.Where(x => x.HairColorCode.Contains(searchModel.HairColor));
                }
                if (!string.IsNullOrEmpty(searchModel.HeadDirection))
                {
                    result = result.Where(x => x.HeadDirection.Contains(searchModel.HeadDirection));
                }

            }




            return result;
        }
    }
}
