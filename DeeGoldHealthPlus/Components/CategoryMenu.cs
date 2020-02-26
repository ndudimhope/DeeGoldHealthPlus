using DeeGoldHealthPlus.models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeeGoldHealthPlus.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepo _categoryRepository;
        public CategoryMenu(ICategoryRepo categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.AllCategories.OrderBy(c => c.CategoryName);
            return View(categories);
        }

    }
}
