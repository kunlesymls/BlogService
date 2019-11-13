using System.Collections.Generic;

namespace Blog.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string AppId { get; set; }
        public string Name { get; set; }
        public ICollection<PostCategory> PostCategories { get; set; }
    }
}
