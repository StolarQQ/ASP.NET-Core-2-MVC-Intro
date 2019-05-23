using System.Collections.Generic;
using PieShop.Models;

namespace PieShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public IList<Pie> Pies { get; set; }
    }
}
