﻿using DeeGoldHealthPlus.models;
using DeeGoldHealthPlus.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeeGoldHealthPlus.Controllers
{
    public class ShoppingCartController: Controller
    {
        private readonly IProductRepo _productRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IProductRepo productRepository, ShoppingCart shoppingCart)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var selectedProduct = _productRepository.AllProducts.FirstOrDefault(p => p.ProductId == productId);

            if (selectedProduct != null)
            {
                _shoppingCart.AddToCart(selectedProduct, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            var selectedProduct = _productRepository.AllProducts.FirstOrDefault(p => p.ProductId == productId);

            if (selectedProduct != null)
            {
                _shoppingCart.RemoveFromCart(selectedProduct);
            }
            return RedirectToAction("Index");
        }
    }
}
