using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollMVC.Model
{
  public  class salary
    {
      [Key]

      public Guid Id { get; set; }
      [Required(ErrorMessage = "Employee Name is Required")]
      public string EmployeeName { get; set; }

      [Required(ErrorMessage = " Salary is Required")]
      public Decimal Salary { get; set; }
    }
}
