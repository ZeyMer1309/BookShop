﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string ImageUrl { get; set; }
    }
}
