using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using trening.Models;
using trening.Methods;
using trening.DBModel;

namespace trening.Controllers
{
    public class HomeController : Controller
    {
      
        SolarisEntities db = new SolarisEntities();
        // GET: Home
        public ActionResult Index()
        {

            var model = OsobyMethod.GetOsoby();

            return View(model);
        }
        [HttpPost]
        public ActionResult Create(Main mainOsoba)
        {


            return(mainOsoba);
        }
    }
}