using PayrollMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using PayrollMVC.Model;
using System.Data.SqlClient;
using PayrollMVC.Models;

namespace PayrollMVC.Controllers
{
    public class DetailsController : Controller
    {
        private DBcontext db = new DBcontext();
        //
        // GET: /Details/
        public async Task<ActionResult> Index()
        {
            return View(await db.EmployeeDetails.ToListAsync());
            //return View();
        }
        public ActionResult Detailslist()
        {
            return View(db.EmployeeDetails.ToList());
            //return View();
        }

        //
        // GET: /Registration/Create
        public ActionResult Create()
        {
            return PartialView();
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Create(Employee_Salary_Details model)
        //{



        //    //if (ModelState.IsValid)
        //    //{
        //    //    foreach (var i in Employee_Salary_Details)
        //    //    {
        //    //        ViewBag.temp = i.EmployeeId;
        //    //    }
        //    //    db.SaveChanges();
        //    //}
        //    //return View(Employee_Salary_Details);
        //    return View();

        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string submitAction, List<Employee_Salary_Details> Employee_Salary_Details)
        {
            if (ModelState.IsValid)
            {
                foreach (var i in Employee_Salary_Details)
                {
                    ViewBag.temp = i.EmployeeId;
                }
                db.SaveChanges();
            }
            return View(Employee_Salary_Details);


        }
    }
}