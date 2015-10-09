﻿using eRAMO.FB.Data;
using eRAMO.FB.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRAMO.FB.Model
{
    public class LevelsModel : ILevel
    {
        [Key]
        public int LevelID { get; set; }

        public int? CertificateID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Notes { get; set; }
    }
}
