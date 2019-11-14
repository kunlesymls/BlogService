using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsVisible { get; set; }
        public Post Post { get; set; }
        public User User { get; set; }
        public ICollection<Reply> Replies { get; set; }

    }
}

