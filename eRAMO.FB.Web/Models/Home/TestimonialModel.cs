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
        readonly UnitOfWork _ctx;

        public TestimonialModel()
        {
            _ctx = new UnitOfWork();
        }
        public List<ClientReviewsModel> ClientReviews { get; set; }
        public List<PartnersModel> Partners { get; set; }

        public List<PartnersModel> GetPartners()
        {
            Partners = _ctx.Partner.GetAll<PartnersModel>().ToList();
            return Partners;
        }
        public List<ClientReviewsModel> GetClientReviews()
        {
            ClientReviews = _ctx.ClientReview.GetAll<ClientReviewsModel>().ToList();
            return ClientReviews;
        }
    }
}