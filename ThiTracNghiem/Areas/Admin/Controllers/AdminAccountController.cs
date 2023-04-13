using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThiTracNghiem.Areas.Admin.Controllers
{
    public class AdminAccountController : Controller
    {
        // GET: Admin/AdminAccount
        public ActionResult Index()
        {
            var iplAdminAccount = new ListAdminAccountModel();
            var model = iplAdminAccount.listAll();
            return View(model);
        }

        // GET: Admin/AdminAccount/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/AdminAccount/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminAccount/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/AdminAccount/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/AdminAccount/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/AdminAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/AdminAccount/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
