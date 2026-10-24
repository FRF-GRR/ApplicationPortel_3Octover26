using ApplicationPortel_3Octover26.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationPortel_3Octover26.Controllers
{
    public class Home1Controller : Controller
    {
        DataBaseContext db = new DataBaseContext();
        public ActionResult Home1Form()
        {
            var Iddd = Convert.ToInt32(Session["RId"]);
            var data = (from S in db.tblRegis1s
                        join D in db.tblDepartments on S.RDepartment equals D.DepartmentId
                        join G in db.tblGenders on S.RGender equals G.GenderId
                        join C in db.tblCountries on S.RCountry equals C.CountryId
                        join State in db.tblStates on S.RState equals State.StateId
                        join City in db.tblCities on S.RCity equals City.CityId
                        where S.RId ==Iddd
                        select new BindtblRegis1
                        {
                            RId = S.RId,
                            RName = S.RName,
                            REmail = S.REmail,
                            RPassword = S.RPassword,
                            RMobile = S.RMobile,
                            RDob = S.RDob,
                            RAge = S.RAge,
                            RDepartment = D.DepartmentName,
                            RGender = G.GenderName,
                            RHobbies = S.RHobbies,
                            RCountry = C.CountryName,
                            RState = State.StateName,
                            RCity = City.CityName,
                            RResume = S.RResume
                        }).ToList();

            return View(data);
        }
        
       
    }
}