using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationPortel_3Octover26.Controllers
{
    public class LogOutController : Controller
    {
        // GET: LogOut
        public ActionResult LogOutForm()
        {
            Session.Abandon();
            return RedirectToAction("LoginForm", "Login");
        }
    }
}