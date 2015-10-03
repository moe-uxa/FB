using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace eRAMO.Administrator
{
    public partial class User : IdentityUser<int, User_Login, User_UserRole, User_Claim>
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User, int> manager)
        { 
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    //New drived classes 
    public partial class User_UserRole : IdentityUserRole<int>
    {
    }

    public partial class User_Claim : IdentityUserClaim<int>
    {
    }

    public partial class User_Login : IdentityUserLogin<int>
    {
    }

    public partial class UserRole : IdentityRole<int, User_UserRole>
    {
        public UserRole()
        {

        }
        public UserRole(string name) { Name = name; }
    }

    public class UserStore : UserStore<User, UserRole, int, User_Login, User_UserRole, User_Claim>
    {
        public UserStore(DbContext context)
            : base(context)
        {
        }
    }

    public class RoleStore : RoleStore<UserRole, int, User_UserRole>
    {
        public RoleStore(DbContext context)
            : base(context)
        {
        }
    }
}
