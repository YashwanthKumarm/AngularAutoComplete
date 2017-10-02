using AutoCompleteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoCompleteMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetCountries()
        {
            using (FirstDatabaseEntities db=new FirstDatabaseEntities())
            {
                var v = db.countries.OrderBy(a => a.countryname).ToList();
                return new JsonResult { Data = v, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }
        public JsonResult GetCountryOrder(string searchStr)
        {
            using (FirstDatabaseEntities db = new FirstDatabaseEntities())
            {
                var countries = db.countries.Where(x => x.countryname.Contains(searchStr)).ToList();
                return new JsonResult { Data = countries, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }
        
    }
}