using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eRAMO.Administrator.Models
{
    public class HomeModel
    {
        public int NumberOfRequests { get; set; }
        public int NumberOfMo3aynaRequests { get; set; }
        public int NumberOfNewOrders { get; set; }
        public int NumberOfOrders { get; set; }
    }
}