﻿using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels
{
    public class CategoryListVm
    {
        public int CategoryId { get; set; }
        public string AppId { get; set; } = "101";

        [Display(Name = "Category Name")]
        [Required]      
        public string Name { get; set; }
    }
}