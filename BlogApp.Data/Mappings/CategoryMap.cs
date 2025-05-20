using BlogApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("EF3BF98C-A244-4DE1-A0AE-A713F671817E"),
                Name = "ASP.NET CORE",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                isDeleted = false

            },
            new Category
            {
                Id = Guid.Parse("2671C8B7-FD88-4A59-841E-817DD64A0F88"),
                Name = "Visual Studio 2022",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                isDeleted = false

            });

        }
    }
    
}
