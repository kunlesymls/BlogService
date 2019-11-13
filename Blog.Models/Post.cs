using System;

namespace Blog.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public int AuthorId { get; set; }
        public string AppId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public DateTime PostedAt { get; set; }
        public bool IsPosted { get; set; }
        public Author Author { get; set; }
    }

    public class Tag
    {
        public int TagId { get; set; }
        public string AppId { get; set; }
        public string Name { get; set; }
    }
}
