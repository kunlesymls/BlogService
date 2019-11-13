using Microsoft.AspNetCore.Identity;
using System;

namespace Blog.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string AppId { get; set; }
        public string UserType { get; set; }
        public DateTime? LastLogin { get; set; }
        public int NoOfLogins { get; set; }
    }
}

