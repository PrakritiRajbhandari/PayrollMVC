using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayrollMVC.Models
{
    public class RegistrationDTO
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Maritalstatus { get; set; }

        public DateTime DateOfBirth { get; set; }
        
        public string Mobile { get; set; }
        public string Email { get; set; }

        public string Address { get; set; }
    }
}