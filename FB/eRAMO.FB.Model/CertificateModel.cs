using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRAMO.FB.Data;
using System.ComponentModel.DataAnnotations;
using eRAMO.FB.Data.Model;

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
        public string ProgramOverview { get; set; }
        public string Objective { get; set; }
        public string ProgramTopics { get; set; }
        public string Charterholders { get; set; }
        public string Candidates { get; set; }
        public string Duration { get; set; }
        public string Time { get; set; }
        public List<InstructorsModel> Instructors { get; set; }
    }
}
