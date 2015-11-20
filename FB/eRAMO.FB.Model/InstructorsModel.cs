using eRAMO.FB.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRAMO.FB.Model
{
    public class InstructorsModel : IInstructor
    {
        [Key]
        public int InstructorsID { set; get; }

        public string Name{ set; get; }

        public string Position { set; get; }

        public string PhotoUrl { set; get; }

        public string Summary { set; get; }

        public string avatar_values { get; set; }
    }
}
