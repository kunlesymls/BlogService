using System;

namespace Blog.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDisabled { get; set; }
        public Post Post { get; set; }
        public User User { get; set; }

    }
}

