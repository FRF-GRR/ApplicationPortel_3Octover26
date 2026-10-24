using ApplicationPortel_3Octover26.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationPortel_3Octover26.Controllers
{
    public class DefaultController : Controller
    {
        DataBaseContext db = new DataBaseContext();
        public ActionResult NewEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewEmployee(tblEmployee emp)
        {
            db.tblEmployees.Add(emp);
            db.SaveChanges();
            return RedirectToAction("ShowEmployee");
        }
        [HttpGet]
        public ActionResult ShowEmployee()
        {
            var data = db.tblEmployees.ToList();
            return View(data);
        }
    }
}