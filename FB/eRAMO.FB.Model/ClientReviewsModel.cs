using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRAMO.FB.Data;

namespace eRAMO.FB.Model
{
    public class ClientReviewsModel:IClientReview
    {
        public int ClientReviewID { get; set; }
        public string Review { get; set; }
        public string ClientName { get; set; }
        public string ClientTitle { get; set; }
    }
}
