using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoodLookTie.Models
{
    public class TieMaterialViewModel
    {
        public List<Tie> Ties { get; set; }
        public SelectList Material { get; set; }
        public string TieMaterial { get; set; }
        public string SearchString { get; set; }
    }
}
