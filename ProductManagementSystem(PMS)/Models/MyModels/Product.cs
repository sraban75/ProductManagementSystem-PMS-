using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagementSystem_PMS_.Models.MyModels
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is Required")]
        [StringLength(35, MinimumLength = 3, ErrorMessage = "Name Must be Three (3) to Thirty Five (35) Characters Long")]
        [Index(IsUnique = true)]
       // [Remote("IsNameAvailble", "Products", ErrorMessage = "Product Already Exist.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "About Requird")]
        [DataType(DataType.MultilineText)]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Address Must be Three (3) to One Hundred (100) Characters Long")]
        public string About { get; set; }

        [Required]
        public double Price { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}