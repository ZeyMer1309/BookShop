using BookShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Business
{
    public class FakeAuthorService : IAuthorService
    {
        private List<Author> authors;

        public FakeAuthorService()
        {
            authors = new List<Author>
            {
                new Author{Id = 1, Name = "George Orwell", Description="Distopya yazarı", Year = 1903,ImageUrl="https://images.jacobinmag.com/wp-content/uploads/2018/08/21102741/orwell.jpg"},
                new Author{Id = 2, Name = "Josè Saramago", Description="Nobel ödüllü yazar", Year = 1922,ImageUrl="https://granta.com/wp-content/uploads/2011/10/saramagocelebration_SM.jpg"},
                new Author{Id = 3, Name = "Josè Mauro De Vasconcelos", Description="Fransız yazar", Year = 1920,ImageUrl="https://sorubankasi.net/img/paragrafresim/7b7853f18f740fd9fc9863388a6b0db7.jpg"}
            };
        }

        public ICollection<Author> GetAuthors()
        {
            return authors;
        }
    }
}
