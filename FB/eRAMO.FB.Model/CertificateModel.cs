using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRAMO.FB.Data;
using System.ComponentModel.DataAnnotations;

namespace eRAMO.FB.Model
{
    public class CertificatesModel : ICertificate
    {
        [Key]
        public int CertificateID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Notes { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsFeatured { get; set; }
    }
}
