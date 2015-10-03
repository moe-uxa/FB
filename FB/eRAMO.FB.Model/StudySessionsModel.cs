using eRAMO.FB.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRAMO.FB.Model
{
    public class StudySessionsModel : IStudySession
    {
        [Key]
        public int StudySessionID { get; set; }

        public int? SubjectID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Notes { get; set; }
    }
}
