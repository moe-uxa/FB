using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;


namespace eRAMO.Administrator.Models
{
    public class ApplicationDbContext : IdentityDbContext<User, UserRole, int, User_Login, User_UserRole, User_Claim>
    {
        public ApplicationDbContext()
            : base("name=FBEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<User>().ToTable("admin.User").Property(p => p.Id).HasColumnName("UserID");

            modelBuilder.Entity<User_UserRole>().ToTable("admin.User_UserRole").Property(p => p.RoleId).HasColumnName("UserRoleID");
            modelBuilder.Entity<User_UserRole>().ToTable("admin.User_UserRole").Property(p => p.UserId).HasColumnName("UserID");

            modelBuilder.Entity<User_Login>().ToTable("admin.User_Login").Property(p => p.UserId).HasColumnName("UserID");

            modelBuilder.Entity<User_Claim>().ToTable("admin.User_Claim").Property(p => p.Id).HasColumnName("User_ClaimID");
            modelBuilder.Entity<User_Claim>().ToTable("admin.User_Claim").Property(p => p.UserId).HasColumnName("UserID");

            modelBuilder.Entity<UserRole>().ToTable("admin.UserRole").Property(p => p.Id).HasColumnName("UserRoleID");
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}