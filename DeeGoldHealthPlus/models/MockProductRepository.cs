using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeeGoldHealthPlus.models
{
    public class MockProductRepository:IProductRepo
    {
        
            private readonly ICategoryRepo _categoryRepo = new MockCategoryRepository();

        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {
                new Product{ ProductId=1, ProductName="Longrich BerryOil", Price= 13100M, ShortDescription="Shenxing Seabuckthorn", LongDescription=" Rich in Omega 3,6,7 & 9 Protects the liver, heart and kidney ", IsProductOfTheWeek=true, Category = _categoryRepo.AllCategories.ToList()[0], },
                new Product{ ProductId=2, ProductName="Longrich Green Tea", Price= 2950M, ShortDescription="Xinchang Tea", LongDescription="It is a very good dietary option containing detoxifier and anti-carcinogens", IsProductOfTheWeek=false},
                new Product{ ProductId=3, ProductName="Longrich Slimming Tea", Price=2950M, ShortDescription="Slimming/Pink Tea", LongDescription="Increases fat burning and improves physical performance", IsProductOfTheWeek=false},
                new Product{ ProductId=4, ProductName="Longrich Vintage Wine", Price=7800M, ShortDescription="100% Natural & Medicinal", LongDescription="Enhances immunity, Detoxifies the body, Enhances sperm production in men, Treatment of impotence and weak erection", IsProductOfTheWeek=true},
                new Product{ ProductId=5, ProductName="Longrich Mengquian", Price=9800M, ShortDescription="Fertility Supplement for Women", LongDescription="It corrects hormonal imbalance, it is anti-aging", IsProductOfTheWeek=false,},
                new Product{ ProductId=6, ProductName="Longrich Arthro SupReviver", Price=9000M, ShortDescription="Unisex", LongDescription="Effective in the treatment of stroke,athritis and rheumatism and also helps to boost the immune system"},
                new Product{ ProductId=7, ProductName="Longrich Mouth Freshner", Price=1100M, ShortDescription="Keeps your mouth fresh and healthy", LongDescription=""},
                new Product{ ProductId=8, ProductName="PhytoScience Double Stemcell", Price=25000M, ShortDescription="Treats over 200 diseases"},
                new Product{},
                new Product{}
            

            };
        public IEnumerable<Product> ProductsOfTheWeek { get; }

        public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
