using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fag_el_Gamous.Models.Filtering.FilteringSample
{
    //Areas by which you can filter the samples table 
    public class FilterSample
    {
        public string Area { get; set; }
        public int? RackNum { get; set; }
        public int? DateYear { get; set; }

    }
}
