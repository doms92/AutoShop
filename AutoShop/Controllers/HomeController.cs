using AutoShop.Models;
using AutoShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAutoPartRepository _autoPartRepository;

        public HomeController(IAutoPartRepository autoPartRepository)
        {
            _autoPartRepository = autoPartRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                AutoPartsOnSale = _autoPartRepository.GetAutoPartsOnSale
            };

            return View(homeViewModel);
        }

      
    }
}
