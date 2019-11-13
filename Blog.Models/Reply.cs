using System;

namespace Blog.Models
{
    public class Reply
    {
        public int ReplyId { get; set; }
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDisabled { get; set; }
        public int InitialReplyId { get; set; }
        public Comment Comment { get; set; }
        public User User { get; set; }
    }
}

