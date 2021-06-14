using AutoShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.ViewModels
{
    public class AutoPartListViewModel
    {
        public IEnumerable<AutoPart> AutoParts { get; set; }
        public string CurrentWorkOrder { get; set; }
    }
}
