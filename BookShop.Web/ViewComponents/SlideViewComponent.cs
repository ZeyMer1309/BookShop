using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Business;

namespace BookShop.Web.ViewComponents
{
    public class SlideViewComponent : ViewComponent
    {
        private readonly IAuthorService authorService;

        public SlideViewComponent(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        public IViewComponentResult Invoke()
        {
            var authors = authorService.GetAuthors();
            return View(authors);
        }
    }
}
