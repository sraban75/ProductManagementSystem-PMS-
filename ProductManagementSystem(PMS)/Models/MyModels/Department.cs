using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagementSystem_PMS_.Models.MyModels
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Code is Required")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Code must be two(2) to Ten(10) character long")]
        [Index(IsUnique = true)]
      //  [Remote("IsCodeAvailble", "Departments", ErrorMessage = "Code Already Exist.")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [StringLength(35, MinimumLength = 3, ErrorMessage = "Name Must be Three (3) to Thirty Five (35) Characters Long")]
        [Index(IsUnique = true)]
       // [Remote("IsNameAvailble", "Departments", ErrorMessage = "Department Already Exist.")]
        public string Name { get; set; }
          
        public virtual ICollection<Employee> Employees { get; set; }

    }
}