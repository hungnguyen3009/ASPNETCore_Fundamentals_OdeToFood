using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication_PluralSight.Models
{
    public interface ICategoryRepository
    {
        // Properties
        IEnumerable<Category> AllCategories { get; }

        // Methods
    }
}
