using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication_PluralSight.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Fruit Pies",
                    Description = "..."
                },

                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Cheese Cakes",
                    Description = "..."
                },

                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Seasonal Pies",
                    Description = "..."
                }
            };
    }
}
