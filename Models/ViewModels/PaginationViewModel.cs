using Fag_el_Gamous.Models.Filtering;
using Fag_el_Gamous.Models.Filtering.FilteringCarbon;
using Fag_el_Gamous.Models.Filtering.FilteringSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fag_el_Gamous.Models.ViewModels
{
    public class PaginationViewModel
    {
        public PageNumberingInfo PageNumberingInfo { get; set; }

        public IEnumerable<Fag_el_Gamous.Models.Samples2> Samples { get; set; }

        public IEnumerable<Fag_el_Gamous.Models.Carbon2> Carbons { get; set; }

        public IEnumerable<Fag_el_Gamous.Models.MasterBurial2> Burials { get; set; }

        public Filter Filter { get; set; }

        public FilterSample FilterSample { get; set; }

        public FilterCarbon FilterCarbon { get; set; }

        public string UrlInfo { get; set; }

    }
}
