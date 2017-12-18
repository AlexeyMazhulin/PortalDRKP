using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using PortalDRKP.Models;

namespace PortalDRKP.Controllers
{
    public class T_1C_SubdivisionController : Controller
    {
        private TContext db = new TContext();

        // GET: T_1C_Subdivision
        public ActionResult Index()
        {
            var t_1C_Subdivision = db.T_1C_Subdivision.Include(t => t.cmnDepartment).Include(t => t.pVertical).Include(t => t.T_1C_Subdivision2);
            return View(t_1C_Subdivision.ToList());
        }

        // GET: T_1C_Subdivision/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_1C_Subdivision t_1C_Subdivision = db.T_1C_Subdivision.Find(id);
            if (t_1C_Subdivision == null)
            {
                return HttpNotFound();
            }
            return View(t_1C_Subdivision);
        }

        // GET: T_1C_Subdivision/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentID = new SelectList(db.cmnDepartment, "ID", "DepartmentName");
            ViewBag.VerticalID = new SelectList(db.pVertical, "ID", "Name");
            ViewBag.Sub_ParentID = new SelectList(db.T_1C_Subdivision, "Sub_ID", "Sub_SID1C");
            return View();
        }

        // POST: T_1C_Subdivision/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Sub_ID,Order,Sub_SID1C,Sub_Name,Sub_ParentID,ModifiedDate,ModifiedStatus,DepartmentID,VerticalID,Show")] T_1C_Subdivision t_1C_Subdivision)
        {
            if (ModelState.IsValid)
            {
                db.T_1C_Subdivision.Add(t_1C_Subdivision);
                db.SaveChanges();
                return RedirectToAction("Sub","Management");
            }

            ViewBag.DepartmentID = new SelectList(db.cmnDepartment, "ID", "DepartmentName", t_1C_Subdivision.DepartmentID);
            ViewBag.VerticalID = new SelectList(db.pVertical, "ID", "Name", t_1C_Subdivision.VerticalID);
            ViewBag.Sub_ParentID = new SelectList(db.T_1C_Subdivision, "Sub_ID", "Sub_SID1C", t_1C_Subdivision.Sub_ParentID);
            return View(t_1C_Subdivision);
        }

        // GET: T_1C_Subdivision/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_1C_Subdivision t_1C_Subdivision = db.T_1C_Subdivision.Find(id);
            if (t_1C_Subdivision == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentID = new SelectList(db.cmnDepartment, "ID", "DepartmentName", t_1C_Subdivision.DepartmentID);
            ViewBag.VerticalID = new SelectList(db.pVertical, "ID", "Name", t_1C_Subdivision.VerticalID);
            ViewBag.Sub_ParentID = new SelectList(db.T_1C_Subdivision, "Sub_ID", "Sub_SID1C", t_1C_Subdivision.Sub_ParentID);
            return View(t_1C_Subdivision);
        }

        // POST: T_1C_Subdivision/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Sub_ID,Order,Sub_SID1C,Sub_Name,Sub_ParentID,ModifiedDate,ModifiedStatus,DepartmentID,VerticalID,Show")] T_1C_Subdivision t_1C_Subdivision)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_1C_Subdivision).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Sub", "Management");
            }
            ViewBag.DepartmentID = new SelectList(db.cmnDepartment, "ID", "DepartmentName", t_1C_Subdivision.DepartmentID);
            ViewBag.VerticalID = new SelectList(db.pVertical, "ID", "Name", t_1C_Subdivision.VerticalID);
            ViewBag.Sub_ParentID = new SelectList(db.T_1C_Subdivision, "Sub_ID", "Sub_SID1C", t_1C_Subdivision.Sub_ParentID);
            return View(t_1C_Subdivision);
        }

        // GET: T_1C_Subdivision/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_1C_Subdivision t_1C_Subdivision = db.T_1C_Subdivision.Find(id);
            if (t_1C_Subdivision == null)
            {
                return HttpNotFound();
            }
            return View(t_1C_Subdivision);
        }

        // POST: T_1C_Subdivision/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            T_1C_Subdivision t_1C_Subdivision = db.T_1C_Subdivision.Find(id);
            db.T_1C_Subdivision.Remove(t_1C_Subdivision);
            db.SaveChanges();
            return RedirectToAction("Sub", "Management");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
