using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fag_el_Gamous.Models.Filtering
{
    public class Filter
    {

        public string BurialSubPlot { get; }
        public string Sex { get; }
        public string HairColor { get; }
        public string EstimateAge { get; }
        public string HeadDirection { get; }

        public bool HasBurialSubPlot => BurialSubPlot != "all";
        public bool HasSex => Sex != "all";
        public bool HasHairColor => HairColor != "all";
        public bool HasEstimateAge => EstimateAge != "all";
        public bool HasHeadDirection => HeadDirection != "all";

    }
}
