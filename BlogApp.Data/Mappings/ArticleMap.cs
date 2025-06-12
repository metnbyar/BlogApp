using BlogApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogApp.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            /* builder.HasKey(x => x.Id);*/ // EF CORE DEFAULT ID ZATEN PRIMARY KEY
            builder.Property(x => x.Title).HasMaxLength(150);

            //Data Seed
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.Net Core Deneme Makalesi 1",
                Content = "Asp.Net Core Lorem İpsummmmm",
                ViewCount = 15,
                CategoryId = Guid.Parse("EF3BF98C-A244-4DE1-A0AE-A713F671817E"),

                ImageId = Guid.Parse("B1CDBFFC-0B49-4B3B-81D8-2FD38B6DD533"),

                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                isDeleted=false,
                UserId= Guid.Parse("E5469F4F-4578-4C4B-9587-01EE9B023B3F")
            },
             new Article
             {
                 Id = Guid.NewGuid(),
                 Title = "Visual Studio Deneme Makalesi 1",
                 Content = " Visual Studio Lorem İpsummmmm",
                 ViewCount = 15,
                 CategoryId = Guid.Parse("2671C8B7-FD88-4A59-841E-817DD64A0F88"),
                 ImageId= Guid.Parse("299A6CF4-5C0F-433C-9F9F-48A66E99CB70"),
                 CreatedBy = "Admin Test",
                 CreatedDate = DateTime.Now,
                 isDeleted = false,
                 UserId= Guid.Parse("4D75B4BA-8E8A-443A-8BB0-3CCC01D27144")
             });

        }
    }
}
