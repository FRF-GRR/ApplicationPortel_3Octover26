using ApplicationPortel_3Octover26.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ApplicationPortel_3Octover26.Controllers
{
    public class UserController : Controller
    {

        DataBaseContext db = new DataBaseContext();
        public ActionResult NewUser(int id = 0)
        {
            ViewBag.btn = "Submit";
            tblEmployee emp = new tblEmployee();
            if (id > 0)
            {
                var data = (from E in db.tblEmployees where E.EmployeeId == id select E).ToList();
                emp.EmployeeId = data[0].EmployeeId;
                emp.EmployeeName = data[0].EmployeeName;
                emp.EmployeeEmail = data[0].EmployeeEmail;
                emp.EmployeePassword = data[0].EmployeePassword;
                emp.EmployeeResume = data[0].EmployeeResume;
                ViewBag.btn = "Update";

            }
            return View(emp);
        }
        [HttpPost]
        public ActionResult NewUser(tblEmployee emp, HttpPostedFileBase File)//HttpPostedFileBase is used to  upload file by user reseved in server controller
        {
            if (emp.EmployeeId > 0)
            {
                if (File != null)
                {
                    var Resume = Path.GetFileName(File.FileName);//it is use for get file name with extension
                    File.SaveAs(Path.Combine(Server.MapPath("~/EmployeePic/"), Resume));//it is used to save file in folder
                    System.IO.File.Delete(Server.MapPath(emp.EmployeeResume));//delete img in folder
                    emp.EmployeeResume = "~/EmployeePic/" + Resume;
                }
                db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ShowUser");
            }
            else
            {
                var Resume = Path.GetFileName(File.FileName);//it is use for get file name with extension
                File.SaveAs(Path.Combine(Server.MapPath("~/EmployeePic/"), Resume));//it is used to save file in folder
                emp.EmployeeResume = "~/EmployeePic/" + Resume;
                db.tblEmployees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("ShowUser");
            }

        }
        [HttpGet]
        public ActionResult ShowUser()
        {
            var data = db.tblEmployees.ToList();
            return View(data);
        }
        public ActionResult DeleteUser(int id = 0)
        {
            var data = db.tblEmployees.Find(id);
            System.IO.File.Delete(Server.MapPath(data.EmployeeResume));//delete img in folder
            db.tblEmployees.Remove(data);
            db.SaveChanges();
            return RedirectToAction("ShowUser");
        }
    }
}