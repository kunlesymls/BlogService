using System.Collections.Generic;

namespace Blog.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public string AppId { get; set; }
        public string Name { get; set; }
        public ICollection<PostTag> PostTags { get; set; }

    }
}
