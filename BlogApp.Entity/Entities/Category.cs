using BlogApp.Core.Entities;

namespace BlogApp.Entity.Entities
{
    public class Category: EntityBase, IEntityBase   
    {
        
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; } //bir kategori de birden çok makale olabilir
    }

}
