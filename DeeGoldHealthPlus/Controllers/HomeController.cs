using DeeGoldHealthPlus.models;
using DeeGoldHealthPlus.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeeGoldHealthPlus.Controllers
{
    public class HomeController: Controller 
    {
        private readonly IProductRepo _productRepository;

        public HomeController(IProductRepo productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProductsOfTheWeek = _productRepository.ProductsOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
