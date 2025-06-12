using BlogApp.Core.Entities;
using BlogApp.Entity.Entities;

namespace BlogApp.Entity.Entities
{
    public class Article : EntityBase
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int  ViewCount { get; set; }
        public Guid CategoryId { get; set; }// burda da aşağıdan gelen category nin id sini almıs olcaz . Bir makalenin bir kategorisi olur
        public Category Category { get; set; } //category classından category gelmis gibi yukarıda
        public Guid? ImageId { get; set; } // bir makalenin bir tane resmi olur.
        public Image Image { get; set; } 

        public Guid UserId { get; set; }
        public AppUser User { get; set; }

    }
}

