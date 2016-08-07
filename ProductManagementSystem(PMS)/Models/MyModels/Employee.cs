using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace ProductManagementSystem_PMS_.Models.MyModels
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Name Requird")]
        [StringLength(35, MinimumLength = 3, ErrorMessage = "Name Must be Three (3) to Thirty Five (35) Characters Long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address Requird")]
        [DataType(DataType.MultilineText)]
        [StringLength(500, MinimumLength = 3, ErrorMessage = "Address Must be Three (3) to Five Hundred (500) Characters Long")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        [StringLength(35)]
        [Index(IsUnique = true)]
        [Remote("IsEmailAvailable", "Employees", ErrorMessage = "Email Already Exist.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile No is Required")]
        [StringLength(20)]
        [Index(IsUnique = true)]
        [Remote("IsMobileAvailable", "Employees", ErrorMessage = "Mobile Number Already Exist.")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Date is Required")]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime Date { get; set; }

        public int ProductId { get; set; }

        public int DepartmentId { get; set; }

        public virtual string Code { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
        public virtual Department Department { get; set; }
    }
}