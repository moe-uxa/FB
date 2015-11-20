using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRAMO.FB.Data.Model;

namespace eRAMO.FB.Model
{
    public class OffersModel:IOffer
    {
        public int OffersID { get; set; }
        public string Detail { get; set; }
        public string image { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? Date { get; set; }
        public string Title { get; set; }
    }
}
