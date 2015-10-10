using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRAMO.FB.Data.Model;

namespace eRAMO.FB.Model
{
    public class NewsModel:INews
    {
        public int NewsID { get; set; }
        public string Text { get; set; }
        public string BannarPhoto { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public DateTime? date { get; set; }
    }
}
