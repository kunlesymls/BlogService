using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blog.ViewModels
{
    public class CategoryListVm
    {
        public int CategoryId { get; set; }
        public string AppId { get; set; } = "101";

        [Display(Name = "Category Name")]
        [Required]
        [StringLength(2)]
        public string Name { get; set; } 
    }
}
