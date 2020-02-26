using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication_PluralSight.Models
{
    public interface IPieRepository
    {
        // Properties
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }

        // Methods
        Pie GetPieById(int pieId);
    }
}
