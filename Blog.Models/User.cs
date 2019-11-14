﻿using System.Collections.Generic;

namespace Blog.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public byte[] Image { get; set; }
        public ICollection<Reply> Replies { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}

