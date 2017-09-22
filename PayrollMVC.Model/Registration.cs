using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollMVC.Model
{
    [Table("Registration")]
     public class Registration
    {
        [Key]

        public Guid EmployeeId { get; set; }
        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Middle Name is Required")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "Marital Status ")]
        public string Maritalstatus { get; set; }
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [MaxLength(20)]
        [Display(Name = "Mobile No")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please add correct phone number.")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

    }
    

    public enum Maritalstatus
    {
        Single,
        Married
        
    }
}
