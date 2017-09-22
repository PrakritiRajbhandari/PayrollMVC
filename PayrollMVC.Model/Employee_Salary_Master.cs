using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollMVC.Model
{
     [Table("Master")]
   public class Employee_Salary_Master
    {

       [Key]
       public Guid Id { get; set; }
       [Required]
       [Display(Name="Emplyee Id")]
       [ForeignKey("Registration")]
       public Guid EmployeeId { get; set; }
       public virtual Registration Registration { get; set; }
       [Required(ErrorMessage="Net Salary is Required")]
       [Display(Name = "Net Salary")]
       public string NetSalary { get; set; }
       [Required(ErrorMessage="Create Date is Required")]
       [Display(Name = "Create Date")]
       [DataType(DataType.DateTime)]
       public string CreateDate { get; set; }
       [Required(ErrorMessage="Created By is Required")]
       [Display(Name = "Create By")]
       public string CreatedBy { get; set; }
        
    }
}
