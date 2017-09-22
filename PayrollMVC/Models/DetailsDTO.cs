using PayrollMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayrollMVC.Models
{
    public class DetailsDTO
    {
        public Guid EmployeeId { get; set; }
        public virtual Registration Registration { get; set; }
        public string Type { get; set; }
        public Decimal Earning { get; set; }
        public Decimal Deduction { get; set; }
    }
}