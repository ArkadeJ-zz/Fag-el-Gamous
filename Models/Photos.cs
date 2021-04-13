using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Fag_el_Gamous.Models
{
    public partial class Photos
    {
        public int PhotoId { get; set; }
        public int? BurialId { get; set; }
        public string UrlLink { get; set; }

        public virtual MasterBurial2 Burial { get; set; }
    }
}
