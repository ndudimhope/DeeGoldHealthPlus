using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeeGoldHealthPlus.models
{
    public class MockCategoryRepository:ICategoryRepo
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=01, CategoryName="General", Description="General household products"},
                new Category{CategoryId=02, CategoryName="WellBeing", Description="Products to promote healthy living"},
                new Category{CategoryId=03, CategoryName="Treatment", Description="Products for treatment of various ailments"}
            };
    }
}
