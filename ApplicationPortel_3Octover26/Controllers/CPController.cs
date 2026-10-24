using ApplicationPortel_3Octover26.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationPortel_3Octover26.Controllers
{
    public class CPController : Controller
    {
        DataBaseContext db = new DataBaseContext();
        public ActionResult CPForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CPForm(CPmodel obj)
        {
            if (obj.newpassword == obj.confirmnewpassword)
            {
                int idd = Convert.ToInt32(Session["RId"]);
                var data = db.tblRegis1s.Find(idd);
                if (data.RPassword == obj.currentpassword)
                {
                    data.RPassword = obj.newpassword;
                    db.Entry(data).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    ViewBag.message = "Password successfully Change!!";
                }
                else
                {
                    ViewBag.message = "Current Password Do not match!!";
                }
            }
            else
            {
                ViewBag.message = "Confirm Password is Not Matching!!";
            }
            return View();
        }
    }
}