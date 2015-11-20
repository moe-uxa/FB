using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRAMO.FB.Data.Model;

namespace eRAMO.FB.Model
{
    public class PartnersModel:IPartner
    {
        public int PartnerID { get; set; }
        public string Imge { get; set; }
        public string Text { get; set; }
    }
}
