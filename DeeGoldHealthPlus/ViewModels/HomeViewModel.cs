﻿using DeeGoldHealthPlus.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeeGoldHealthPlus.ViewModels
{
    public class HomeViewModel
    {

        public IEnumerable<Product> ProductsOfTheWeek { get; set; }
    }
}
