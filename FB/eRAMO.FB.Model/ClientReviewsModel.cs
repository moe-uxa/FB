using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRAMO.FB.Data;
using eRAMO.FB.Data.Model;

namespace eRAMO.FB.Model
{
    public class ClientReviewsModel : IClientReview
    {
        public int ClientReviewID { get; set; }
        public string Review { get; set; }
        public string ClientName { get; set; }
        public string ClientTitle { get; set; }
        public string ClientPhoto { get; set; }
    }
}
