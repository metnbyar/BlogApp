using BlogApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogApp.Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("B1CDBFFC-0B49-4B3B-81D8-2FD38B6DD533"),
                FileName = "images/testimage",
                FileType = "jpg",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                isDeleted = false
            },
            new Image
            {
                Id = Guid.Parse("299A6CF4-5C0F-433C-9F9F-48A66E99CB70"),
                FileName = "images/vstest",
                FileType = "jpg",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                isDeleted = false
            }
            );
        }
    }
}
