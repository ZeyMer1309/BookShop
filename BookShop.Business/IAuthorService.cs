using BookShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Business
{
    public interface IAuthorService
    {
        ICollection<Author> GetAuthors();
    }
}
