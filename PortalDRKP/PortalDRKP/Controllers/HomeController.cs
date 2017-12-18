using PortalDRKP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalDRKP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        Context db = new Context();
        public ActionResult Deps()
        {
            List<drkpDepartment> dep = db.drkpDepartment.ToList();
            return PartialView(dep);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Management()
        {
            return View();
        }
    }
}