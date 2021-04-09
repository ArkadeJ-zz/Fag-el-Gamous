using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Fag_el_Gamous.Models
{
    public partial class Samples2
    {
        public int SampleId { get; set; }
        public int? BurialId { get; set; }
        public string LocConcat { get; set; }
        public int? RackNum { get; set; }
        public int? BagNum { get; set; }
        public int? LowNs { get; set; }
        public int? HighNs { get; set; }
        public string NS { get; set; }
        public int? LowEw { get; set; }
        public int? HighEw { get; set; }
        public string EW { get; set; }
        public string Area { get; set; }
        public long? BurialNum { get; set; }
        public string SubBurialNum { get; set; }
        public int? ClusterNum { get; set; }
        public int? DateDay { get; set; }
        public int? DateMonth { get; set; }
        public int? DateYear { get; set; }
        public string PreviouslySampled { get; set; }
        public string Notes { get; set; }
        public string Initials { get; set; }

        public virtual MasterBurial2 Burial { get; set; }
    }
}
