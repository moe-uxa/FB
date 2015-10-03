using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRAMO.FB.Model
{
    public class AdminUser
    {
        public AdminUser()
        {
            Roles = new List<string>();
        }

        [Key]
        public int UserID { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Roles")]
        public string RoleNames { get; set; }

        [Display(Name = "Roles")]
        public List<string> Roles { get; set; }

        [Display(Name = "Super Admin?")]
        public bool IsSuperAdmin { get; set; }

        [Display(Name = "Locked Out?")]
        public bool IsDisabled { get; set; }
    }
}
