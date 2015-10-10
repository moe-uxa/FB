using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eRAMO.FB.Manager;
using eRAMO.FB.Model;

namespace eRAMO.FB.Web.Models.Home
{
    public class OfferModel
    {
        readonly UnitOfWork _ctx;

        public OfferModel()
        {
            _ctx = new UnitOfWork();
        }
        public List<OffersModel> Offers { get; set; }

        public List<OffersModel> GetOffers()
        {
            Offers = _ctx.Offer.GetAll<OffersModel>().ToList();
            return Offers;
        }
    }
}