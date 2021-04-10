using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fag_el_Gamous.Models.Filtering
{
    public class Filter
    {

        public string BurialSubPlot { get; set; }
        public string Sex { get; set; }
        public string HairColor { get; set; }
        //public string EstimateAge { get; set; }
        public string HeadDirection { get; set; }

        //public bool HasBurialSubPlot => BurialSubPlot != "all";
        //public bool HasSex => Sex != "all";
        //public bool HasHairColor => HairColor != "all";
        //public bool HasEstimateAge => EstimateAge != "all";
        //public bool HasHeadDirection => HeadDirection != "all";

    }
}
