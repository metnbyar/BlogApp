using BlogApp.Data.Mappings;
using BlogApp.Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Context
{
    public class AppDbContext : IdentityDbContext<AppUser,AppRole,Guid,AppUserClaim,AppUserRole,AppUserLogin,AppRoleClaim,AppUserToken>
    {
        protected AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) //model olusturulmadan configurasyon sağlar
        {
            //builder.ApplyConfiguration(new ArticleMap());  tek tek yaparsak böyle olur.
            //builder.Entity<Article>().Property(x=>x.Title).HasMaxLength(150); map classları yerine burda da yapabiliriz ama clean code olmaz
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //IEntityTypeConfiguration dan kalıtım alan tüm map classlarını oto tanımlar.

        }
    }
}
