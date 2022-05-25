using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int PageCount { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public string ImageUrl { get; set; }

    }
}
