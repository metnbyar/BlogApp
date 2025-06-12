using BlogApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BlogApp.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");
            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("E5469F4F-4578-4C4B-9587-01EE9B023B3F"),
                RoleId = Guid.Parse("BDEA8C46-7F11-4AF4-AF0C-D733719F292E")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("4D75B4BA-8E8A-443A-8BB0-3CCC01D27144"),
                RoleId = Guid.Parse("D4A9834E-545E-46C3-800A-D327C375CAE5")

            });
        }
    }
}
