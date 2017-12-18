using PortalDRKP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace PortalDRKP.Controllers
{
    public class ManagementController : Controller
    {
        // GET: Management
        public ActionResult DRKP()
        {
            return View();
        }

        TContext db = new TContext();
        
        public ActionResult Sub()
        {
            IEnumerable<T_1C_Subdivision> Isubs = db.T_1C_Subdivision;
            var subs = Isubs.Where(p => p.Show == 1).ToList();
            return PartialView(subs);
            
        }
        public ActionResult Emp()
        {
            IEnumerable<T_1C_Users> Iusers = db.T_1C_Users;
            var users = Iusers.Where(p => p.Sub_ID == 10).ToList();
            return PartialView(users);

        }
    }
}