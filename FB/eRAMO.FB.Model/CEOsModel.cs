﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRAMO.FB.Data.Model;

namespace eRAMO.FB.Model
{
    public class CEOsModel:ICEO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string imge { get; set; }
    }
}
