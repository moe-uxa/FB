using eRAMO.FB.Manager;
using eRAMO.FB.Web.Models;
using eRAMO.FB.Web.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eRAMO.FB.Web.Controllers
{
    public class HomeController : Controller
    {

   
        public ActionResult Index()
        {
            HomeModel model = new HomeModel();

            HeaderModel headerModel = new HeaderModel();
            var TestimonialModel = new TestimonialModel();
            var blog = new BlogsModel();
            TestimonialModel.GetClientReviews();
            headerModel.Certificates = headerModel.GetFeaturedCertificates();
            model.Testimonial = TestimonialModel;
            model.Header = headerModel;
            model.Blogs=new BlogsModel();
            model.Blogs.GetNews();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}