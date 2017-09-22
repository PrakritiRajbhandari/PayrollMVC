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
    public class RegistrationController : Controller
    {
        private DBcontext db = new DBcontext();
        //
        // GET: /Registration/
        public async Task<ActionResult> Index()
        {
            return View (await db.Registration.ToListAsync());
            //return View();
        }
        public ActionResult Registrationlist()
        {
            return View(db.Registration.ToList());
            //return View();
        }


        //
        // GET: /Registration/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registration Registration = await db.Registration.FindAsync(id);
            if (Registration == null)
            {
                return HttpNotFound();
            }
            return View(Registration);
            //return View();
        }

        //
        // GET: /Registration/Create
        public ActionResult Create()
        {
            return PartialView();
        }


        //
        // POST: /Registration/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(RegistrationDTO model)
        {
            //if (ModelState.IsValid)
            //{
            //    Registration.EmployeeId = Guid.NewGuid();
            //    db.Registration.Add(Registration);
            //    await db.SaveChangesAsync();

            //    return RedirectToAction("Index");
            //}
            //return View(Registration);

            int iCount = (from b in db.Registration
                          where b.FirstName == model.FirstName
                          select b).Count();
            if (iCount > 0)
            {
                return Json(new { success = false, message = "Duplicate Employee name." }, JsonRequestBehavior.AllowGet);
            }

            var Registration = new Registration
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                Gender = model.Gender,
                Maritalstatus = model.Maritalstatus,
                DateOfBirth = model.DateOfBirth,
                Mobile = model.Mobile,
                Email = model.Email,
                Address = model.Address
            };
            db.Registration.Add(Registration);
            await db.SaveChangesAsync();

            return Json(new { success = true, message = "Data successfully saved." }, JsonRequestBehavior.AllowGet);
        }



        //
        // GET: /Registration/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Registration Registration = await db.Registration.FindAsync(id);
            if (Registration == null)
            {
                return HttpNotFound();
            }
            return View(Registration);
            //return View();
        }
        //
        // POST: /Registration/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "EmployeeId,FirstName,MiddleName,LastName,Gender,Maritalstatus,Dateofbirth,Mobile,Email,Address")] Registration Registration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Registration).State = EntityState.Modified;
                await db.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View(Registration);
            //return View();
        }


        //
        // GET: /Registration/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //
        // POST: /Registration/Delete/5
        public async Task<ActionResult> Delete(Guid id)
        {
            Registration Registration = await db.Registration.FindAsync(id);

            try
            {
                db.Registration.Remove(Registration);
                await db.SaveChangesAsync();
                TempData["Msg"] = "Data has been deleted successfully.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Registration", "DeleteConfirmed"));
            }
           // return View();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
