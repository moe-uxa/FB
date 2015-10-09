using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eRAMO.FB.Data;
using eRAMO.FB.Manager;
using eRAMO.FB.Model;

namespace eRAMO.FB.Web.Models.Home
{
    public class TestimonialModel
    {
        public List<ClientReviewsModel> ClientReviews { get; set; }
        readonly UnitOfWork _ctx = new UnitOfWork();

        public List<ClientReviewsModel> GetClientReviews()
        {
            ClientReviews = _ctx.ClientReview.GetAll<ClientReviewsModel>().ToList();
            return ClientReviews;
        }
    }
}