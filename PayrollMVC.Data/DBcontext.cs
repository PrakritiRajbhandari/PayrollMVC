using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollMVC.Model;

namespace PayrollMVC.Data
{

    public class DBcontext : DbContext
    {
        public static DBcontext Create()
        {
            return new DBcontext();
        }

        public DBcontext()
            : base("DefaultConnection")
        {

        }
        public DbSet<Registration> Registration { get; set; }
        //public DbSet<Gender> Gender { get; set; }
        public DbSet<salary> Salary { get; set; }
        public DbSet<Employee_Salary_Details> EmployeeDetails { get; set; }
        public DbSet<Employee_Salary_Master> EmployeeMaster { get; set; }

    }

    
}
