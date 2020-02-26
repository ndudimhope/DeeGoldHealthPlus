using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeeGoldHealthPlus.models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        public Decimal Price { get; set; }

        public bool IsProductOfTheWeek { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }


    }
}
