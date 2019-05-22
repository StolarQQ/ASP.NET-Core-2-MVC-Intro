using System.Collections.Generic;
using System.Linq;

namespace PieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private IEnumerable<Pie> Pies = new List<Pie>
        {
            new Pie
            {
                Id = 1, ImageThumbnailUrl = "test", ImageUrl = "test",
                IsInStock = true, IsPieOfTheWeek = true, ShortDescription = "test",
                LongDescription = "test123", Name = "kozak", Price = 10
            },
            new Pie
            {
                Id = 2, ImageThumbnailUrl = "test1", ImageUrl = "tes1t",
                IsInStock = true, IsPieOfTheWeek = true, ShortDescription = "tes1t",
                LongDescription = "test123", Name = "kozak1", Price = 101
            }
        };
        
        public IEnumerable<Pie> GetAllPies()
        {
            return Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return Pies.SingleOrDefault(x => x.Id == pieId);
        }
    }
}
