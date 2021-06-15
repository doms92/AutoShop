using AutoShop.Models;
using AutoShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Controllers
{
    public class AutoPartController : Controller
    {
        private readonly IAutoPartRepository _autoPartRepository;
        private readonly IWorkOrderRepository _workOrderRepository;

        public AutoPartController(IAutoPartRepository autoPartRepository, IWorkOrderRepository workOrderRepository)
        {
            _autoPartRepository = autoPartRepository;
            _workOrderRepository = workOrderRepository;

        }

        public IActionResult List()
        {
            var autopartListViewModel = new AutoPartListViewModel();
            autopartListViewModel.AutoParts = _autoPartRepository.GetAllAutoParts;
            autopartListViewModel.CurrentWorkOrder = "BestSellers";
            return View(autopartListViewModel);
  
           // return View(_autoPartRepository.GetAllAutoParts);
        }

        public IActionResult Details(int id)
        {
            var autoparts = _autoPartRepository.GetAutoPartsById(id);
            if (autoparts == null)
                return View(autoparts);

            return View(autoparts);
        }
    }
}
