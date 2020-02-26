using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication_PluralSight.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepo = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie
                {
                    PieId = 1,
                    Name = "Strawberry Pie",
                    Price = 15.95m,
                    ShortDescription = "...",
                    LongDescription = "...",
                    Category = _categoryRepo.AllCategories.ToList()[0],
                    ImageUrl = "...",
                    ImageThumbnailUrl = "...",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    AllergyInformation = "..."
                },
                new Pie
                {
                    PieId = 2,
                    Name = "Cheese Cake",
                    Price = 15.95m,
                    ShortDescription = "...",
                    LongDescription = "...",
                    Category = _categoryRepo.AllCategories.ToList()[1],
                    ImageUrl = "...",
                    ImageThumbnailUrl = "...",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    AllergyInformation = "..."
                },
                new Pie
                {
                    PieId = 3,
                    Name = "Pumpkin Pie",
                    Price = 15.95m,
                    ShortDescription = "...",
                    LongDescription = "...",
                    Category = _categoryRepo.AllCategories.ToList()[2],
                    ImageUrl = "...",
                    ImageThumbnailUrl = "...",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    AllergyInformation = "..."
                },
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
