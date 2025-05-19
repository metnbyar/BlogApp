using BlogApp.Core.Entities;

namespace BlogApp.Entity.Entities
{
    public class Image:EntityBase,IEntityBase
    {
        
        public string FileName { get; set; }
        public string FileType { get; set; }
        public ICollection<Article> Articles { get; set; } // Bir resim birden fazla makalede olabilir.

    }
}
