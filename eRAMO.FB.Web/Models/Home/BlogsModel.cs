using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eRAMO.FB.Manager;
using eRAMO.FB.Model;

namespace eRAMO.FB.Web.Models.Home
{
    public class BlogsModel
    {
        public List<NewsModel> News { get; set; }
        readonly UnitOfWork _ctx = new UnitOfWork();

        public List<NewsModel> GetNews()
        {
            News = _ctx.News.GetAll<NewsModel>().ToList();
            return News;
        }
    }
}