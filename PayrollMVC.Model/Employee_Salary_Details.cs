using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollMVC.Model
{
      [Table("Details")]
  public  class Employee_Salary_Details
    {
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Emplyee Id")]
        [ForeignKey("Registration")]
        public Guid EmployeeId { get; set; }
        public virtual Registration Registration { get; set; }
        [Required(ErrorMessage = "Type is Required")]
        [Display(Name = "Type")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Earning is Required")]
        [Display(Name = "Earning")]

        public Decimal Earning { get; set; }
        [Required(ErrorMessage = "Deduction is Required")]
        [Display(Name = "Deduction")]
        public Decimal Deduction { get; set; }

    }
}
