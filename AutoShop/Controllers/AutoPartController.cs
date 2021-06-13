using AutoShop.Models;
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

        public ViewResult List()
        {
            return View(_autoPartRepository.GetAllAutoParts);
        }
    }
}
