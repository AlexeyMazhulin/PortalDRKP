using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PortalDRKP.Models;

namespace PortalDRKP.Controllers
{
    public class T_1C_UsersController : Controller
    {
        private TContext db = new TContext();

        // GET: T_1C_Users
        public ActionResult Index(int? subid)
        {
            IEnumerable<T_1C_Users> IUsers = db.T_1C_Users;
            var users = db.T_1C_Users.Where(p => p.Sub_ID == subid).ToList();
            return View(users.ToList());
        }

        // GET: T_1C_Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_1C_Users t_1C_Users = db.T_1C_Users.Find(id);
            if (t_1C_Users == null)
            {
                return HttpNotFound();
            }
            return View(t_1C_Users);
        }

        // GET: T_1C_Users/Create
        public ActionResult Create()
        {
            ViewBag.VerticalID = new SelectList(db.pVertical, "ID", "Name");
            ViewBag.Sub_ID = new SelectList(db.T_1C_Subdivision, "Sub_ID", "Sub_SID1C");
            ViewBag.User_ParentID = new SelectList(db.T_1C_Users, "User_ID", "User_SID1C");
            return View();
        }

        // POST: T_1C_Users/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "User_ID,Order,User_SID1C,User_ID1C,User_Name,User_ParentID,Sub_ID,SUBDIVISION,Reg_ID,REGION,MODIFIEDSTATUS,ModifiedDate,PROJECT,Proj_ID,VerticalID")] T_1C_Users t_1C_Users)
        {
            if (ModelState.IsValid)
            {
                db.T_1C_Users.Add(t_1C_Users);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.VerticalID = new SelectList(db.pVertical, "ID", "Name", t_1C_Users.VerticalID);
            ViewBag.Sub_ID = new SelectList(db.T_1C_Subdivision, "Sub_ID", "Sub_SID1C", t_1C_Users.Sub_ID);
            ViewBag.User_ParentID = new SelectList(db.T_1C_Users, "User_ID", "User_SID1C", t_1C_Users.User_ParentID);
            return View(t_1C_Users);
        }

        // GET: T_1C_Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_1C_Users t_1C_Users = db.T_1C_Users.Find(id);
            if (t_1C_Users == null)
            {
                return HttpNotFound();
            }
            ViewBag.VerticalID = new SelectList(db.pVertical, "ID", "Name", t_1C_Users.VerticalID);
            ViewBag.Sub_ID = new SelectList(db.T_1C_Subdivision, "Sub_ID", "Sub_SID1C", t_1C_Users.Sub_ID);
            ViewBag.User_ParentID = new SelectList(db.T_1C_Users, "User_ID", "User_SID1C", t_1C_Users.User_ParentID);
            return View(t_1C_Users);
        }

        // POST: T_1C_Users/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "User_ID,Order,User_SID1C,User_ID1C,User_Name,User_ParentID,Sub_ID,SUBDIVISION,Reg_ID,REGION,MODIFIEDSTATUS,ModifiedDate,PROJECT,Proj_ID,VerticalID")] T_1C_Users t_1C_Users)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_1C_Users).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.VerticalID = new SelectList(db.pVertical, "ID", "Name", t_1C_Users.VerticalID);
            ViewBag.Sub_ID = new SelectList(db.T_1C_Subdivision, "Sub_ID", "Sub_SID1C", t_1C_Users.Sub_ID);
            ViewBag.User_ParentID = new SelectList(db.T_1C_Users, "User_ID", "User_SID1C", t_1C_Users.User_ParentID);
            return View(t_1C_Users);
        }

        // GET: T_1C_Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_1C_Users t_1C_Users = db.T_1C_Users.Find(id);
            if (t_1C_Users == null)
            {
                return HttpNotFound();
            }
            return View(t_1C_Users);
        }

        // POST: T_1C_Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            T_1C_Users t_1C_Users = db.T_1C_Users.Find(id);
            db.T_1C_Users.Remove(t_1C_Users);
            db.SaveChanges();
            return RedirectToAction("Index");
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
