using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fag_el_Gamous.Models
{
    public class Filters
    {
        public Filters(string filterstring)
        {
            FilterString = filterstring ?? "all-all-all-all-all";
            string[] filters = FilterString.Split('-');
            BurialSubPlot = filters[0];
            Sex = filters[1];
            HairColor = filters[2];
            EstimateAge = filters[3];
            HeadDirection = filters[4];
        }

        public string FilterString { get; }
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
