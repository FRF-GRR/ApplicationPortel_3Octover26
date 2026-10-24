using ApplicationPortel_3Octover26.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationPortel_3Octover26.Controllers
{
    public class Ragistration1Controller : Controller
    {
        DataBaseContext db = new DataBaseContext();

        public ActionResult AddUser(int id = 0)
        {
            ViewBag.BTN = "Submit";
            AddRagisAndCollection obj = new AddRagisAndCollection();
            obj.listcountries = db.tblCountries.ToList();
            obj.listdepartments = db.tblDepartments.ToList();
            var hobbies = db.tblHobbies.ToList();
            obj.listhobbies = hobbies.Select(h => new hobbiesbind
            {
                HobbiesId = h.HobbiesId,
                HobbiesName = h.HobbiesName,
                ischeked = false
            }).ToList();

            obj.listgenders = db.tblGenders.ToList();

            if (id > 0)
            {
                var data = (from S in db.tblRegis1s where S.RId == id select S).ToList();
                obj.RId = data[0].RId;
                obj.RName = data[0].RName;
                obj.REmail = data[0].REmail;
                obj.RPassword = data[0].RPassword;
                obj.RMobile = data[0].RMobile;

                obj.RDob = data[0].RDob;
                obj.RAge = data[0].RAge;
                obj.RDepartment = data[0].RDepartment;
                obj.RGender = data[0].RGender;
                string[] arr = data[0].RHobbies.Split(',');
                foreach (var item in obj.listhobbies)
                {
                    foreach (var hobby in arr)
                    {
                        if (item.HobbiesName == hobby)
                        {
                            item.ischeked = true;
                            break; // Exit the inner loop once a match is found
                        }
                    }
                }

                obj.RCountry = data[0].RCountry;
                obj.RState = data[0].RState;
                obj.RCity = data[0].RCity;
                obj.RResume = data[0].RResume;
                ViewBag.BTN = "Update";
            }
            obj.liststate = (from S in db.tblStates where S.CountryId == obj.RCountry select S).ToList();
            obj.listcity = (from C in db.tblCities where C.stateId == obj.RState select C).ToList();
            return View(obj);
        }
        [HttpPost]

        public ActionResult AddUser(AddRagisAndCollection obj, HttpPostedFileBase ResumeFile)
        {

            string pp = "";
            if (obj.listhobbies != null)
            {
                foreach (var item in obj.listhobbies)
                {
                    if (item.ischeked)
                        pp += item.HobbiesName + ",";
                }
            }
            pp = pp.TrimEnd(',');

            tblRegis1 regisObj = new tblRegis1();
            regisObj.RId = obj.RId;   // update ke liye zaroori
            regisObj.RName = obj.RName;
            regisObj.REmail = obj.REmail;
            regisObj.RPassword = obj.RPassword;
            regisObj.RMobile = obj.RMobile;
            regisObj.RDob = obj.RDob;
            regisObj.RAge = obj.RAge;
            regisObj.RDepartment = obj.RDepartment;
            regisObj.RGender = obj.RGender;
            regisObj.RHobbies = pp;
            regisObj.RCountry = obj.RCountry;
            regisObj.RState = obj.RState;
            regisObj.RCity = obj.RCity;


            if (obj.RId > 0)
            {
                if (ResumeFile != null && ResumeFile.ContentLength > 0)
                {
                    var Resume = Path.GetFileName(ResumeFile.FileName);
                    ResumeFile.SaveAs(Server.MapPath("~/ResumeFile/") + Resume);
                    if (!string.IsNullOrEmpty(obj.RResume))
                    {
                        System.IO.File.Delete(Server.MapPath(obj.RResume));//File.Delete ko use karte hai System.IO ko use karte hai 
                    }
                    regisObj.RResume = "~/ResumeFile/" + Resume;
                }
                db.Entry(regisObj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ShowUsers");
            }
            else
            {

                var Resume = Path.GetFileName(ResumeFile.FileName);
                ResumeFile.SaveAs(Server.MapPath("~/ResumeFile/") + Resume);
                regisObj.RResume = "~/ResumeFile/" + Resume;
                db.tblRegis1s.Add(regisObj);

            }
            db.SaveChanges();

            return RedirectToAction("ShowUsers");
        }
        [HttpGet]
        public ActionResult ShowUsers()
        {
            var data = (from S in db.tblRegis1s
                        join D in db.tblDepartments on S.RDepartment equals D.DepartmentId
                        join G in db.tblGenders on S.RGender equals G.GenderId
                        join C in db.tblCountries on S.RCountry equals C.CountryId
                        join State in db.tblStates on S.RState equals State.StateId
                        join City in db.tblCities on S.RCity equals City.CityId
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



        [HttpGet]
        public ActionResult DeleteUsers(int id = 0)
        {
            var data = db.tblRegis1s.Find(id);
            System.IO.File.Delete(Server.MapPath(data.RResume));
            db.tblRegis1s.Remove(data);
            db.SaveChanges();
            return RedirectToAction("ShowUsers");
        }


        public JsonResult BindState(int A = 0)
        {
            var data = (from S in db.tblStates where S.CountryId == A select S).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult BindCity(int B = 0)
        {
            var data = (from S in db.tblCities where S.stateId == B select S).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
