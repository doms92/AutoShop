using AutoShop.Models;
using AutoShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IAutoPartRepository _autoPartRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IAutoPartRepository autoPartRepository, ShoppingCart shoppingCart)
        {
            _autoPartRepository = autoPartRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int autoPartId)
        {
            var selectedAutoPart = _autoPartRepository.GetAllAutoParts.FirstOrDefault(c => c.AutoPartsId == autoPartId);

            if (selectedAutoPart != null)
            {
                _shoppingCart.AddToCart(selectedAutoPart, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int autoPartId)
        {
            var selectedAutoPart = _autoPartRepository.GetAllAutoParts.FirstOrDefault(c => c.AutoPartsId == autoPartId);

            if (selectedAutoPart != null)
            {
                _shoppingCart.RemoveFromCart(selectedAutoPart);
            }

            return RedirectToAction("Index");
        }

    }
}
