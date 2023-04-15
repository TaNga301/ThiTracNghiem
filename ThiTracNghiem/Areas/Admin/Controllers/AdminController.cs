using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using model;
using model.Framework;

namespace ThiTracNghiem.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        private ThiTracNgiem db = new ThiTracNgiem();

        // GET: Admin/Admin
        public ActionResult Index()
        {
            var iplAdmin = new AdminModel();
            var model = iplAdmin.listAll();
            return View(model);
            //var admins = db.Admins.Include(a => a.Role);
            //return View(admins.ToList());
        }

        // GET: Admin/Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            model.Framework.Admin admin = db.Admins.Find(id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        // GET: Admin/Admin/Create
        public ActionResult Create()
        {
            ViewBag.role_id = new SelectList(db.Roles, "role_id", "role_name");
            return View();
        }

        // POST: Admin/Admin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "admin_id,role_id,user_name,user_pass,admin_name,birthday,email,phone,address")] model.Framework.Admin admin)
        {
            if (ModelState.IsValid)
            {
                db.Admins.Add(admin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.role_id = new SelectList(db.Roles, "role_id", "role_name", admin.role_id);
            return View(admin);
        }

        // GET: Admin/Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            model.Framework.Admin admin = db.Admins.Find(id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            ViewBag.role_id = new SelectList(db.Roles, "role_id", "role_name", admin.role_id);
            return View(admin);
        }

        // POST: Admin/Admin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "admin_id,role_id,user_name,user_pass,admin_name,birthday,email,phone,address")] model.Framework.Admin admin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(admin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.role_id = new SelectList(db.Roles, "role_id", "role_name", admin.role_id);
            return View(admin);
        }

        // GET: Admin/Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            model.Framework.Admin admin = db.Admins.Find(id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        // POST: Admin/Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            model.Framework.Admin admin = db.Admins.Find(id);
            db.Admins.Remove(admin);
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
