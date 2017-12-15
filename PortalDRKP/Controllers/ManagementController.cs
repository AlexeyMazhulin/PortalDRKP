using PortalDRKP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

            //List<T_1C_Subdivision> sub = db.T_1C_Subdivision.ToList();

            return PartialView(subs);
            
        }

        public ActionResult Edit(int id)
        {
            return View(id);
        }


    }
}