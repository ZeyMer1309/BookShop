using BookShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Business
{
    public class FakeBookService : IBookService
    {
        private List<Book> books;

        public FakeBookService()
        {
            books = new List<Book>
            {
                new Book{ Id = 1, Name = "1984", Author = "George Orwell", Price = 35, Discount = 0.35, Description = "Kitap", CategoryId = 1, ImageUrl="https://img.kitapyurdu.com/v1/getImage/fn:11484453/wh:true/wi:400"},
                new Book{ Id = 2, Name = "Körlük", Author = "Josè Saramago", Price = 58, Discount = 0.32, Description = "Kitap", CategoryId = 1, ImageUrl="https://img.kitapyurdu.com/v1/getImage/fn:11515706/wh:true/wi:400"},
                new Book { Id = 3, Name = "Şeker Portakalı", Author = "Josè Mauro De Vasconcelos", Price = 45, Discount = 0.60, Description = "Kitap", CategoryId = 1, ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:11462950/wh:true/wi:400" },
                new Book { Id = 4, Name = "A", Price = 35, Discount = 0.35, Description = "Kitap", CategoryId = 1, ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:11484453/wh:true/wi:400" },
                new Book { Id = 5, Name = "B", Price = 58, Discount = 0.32, Description = "Kitap", CategoryId = 1, ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:11515706/wh:true/wi:400" },
                new Book { Id = 6, Name = "C", Price = 45, Discount = 0.60, Description = "Kitap", CategoryId = 1, ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:11462950/wh:true/wi:400" }
            };
        }

        public ICollection<Book> GetBooks()
        {
            return books;
        }
    }
}
