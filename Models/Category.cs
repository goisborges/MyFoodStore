using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFoodStore.Models
{
    public class Category
    { 

        [Range(1, 9999999)]
        [Display(Name = "Category Id")] //This sets an alias globally
        public int CategoryId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        public string Name { get; set; }
    }
}
