using AutoShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<AutoPart> AutoPartsOnSale { get; set; }
    }
}
