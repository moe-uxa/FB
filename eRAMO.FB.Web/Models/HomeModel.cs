using eRAMO.FB.Manager;
using eRAMO.FB.Web.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eRAMO.FB.Web.Models
{
    public class HomeModel
    {
        public HeaderModel Header { get; set; }
        public TestimonialModel Testimonial { get; set; }
        public BlogsModel Blogs { get; set; }

        public HomeModel()
        {
            Header = new HeaderModel();
            Testimonial = new TestimonialModel();
            Blogs = new BlogsModel();
        }
    }
}