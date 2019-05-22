using System.Collections.Generic;

namespace PieShop.Models
{
    interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();

        Pie GetPieById(int pieId);
    }
}
