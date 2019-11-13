using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AppId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public string Description { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Image { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
