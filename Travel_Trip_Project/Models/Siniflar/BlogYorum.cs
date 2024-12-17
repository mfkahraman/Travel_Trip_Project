using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Blogs {get; set;}
        public IEnumerable<Comment> Comments {get; set;}
    }
}