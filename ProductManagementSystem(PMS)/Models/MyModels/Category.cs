using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductManagementSystem_PMS_.Models.MyModels
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category Name Requird")]
        [StringLength(35, MinimumLength = 3, ErrorMessage = "Name Must be Three (3) to Thirty Five (35) Characters Long")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}