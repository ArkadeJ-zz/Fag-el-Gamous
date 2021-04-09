using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fag_el_Gamous.Models.ViewModels
{
    public class PaginationViewModel
    {
        public PageNumberingInfo PageNumberingInfo { get; set; }

        public IEnumerable<Fag_el_Gamous.Models.Carbon2> Carbons { get; set; }


    }
}
