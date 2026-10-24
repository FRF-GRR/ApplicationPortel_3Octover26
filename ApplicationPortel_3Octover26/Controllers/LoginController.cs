using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApplicationPortel_3Octover26.Models;

namespace ApplicationPortel_3Octover26.Controllers
{
    public class LoginController : Controller
    {
        DataBaseContext db = new DataBaseContext();
        public ActionResult LoginForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginForm(tblRegis1 model)
        {
           
                var data = (from R in db.tblRegis1s where R.REmail == model.REmail && R.RPassword == model.RPassword select R).ToList();
                if (data.Count > 0)
                {
                Session["RId"] = data[0].RId;
                   return RedirectToAction("Home1Form", "Home1");
                }

                ViewBag.Message = "Invalid Email or Password !!";
            
            return View();
        }
    }
}