using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ThiTracNghiem.Areas.Admin.Code;
using ThiTracNghiem.Areas.Admin.Models;

namespace ThiTracNghiem.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            //var result = new AdminAcountModel().AdminLogin(model.user_name, model.user_pass);
            if(Membership.ValidateUser(model.user_name,model.user_pass) && ModelState.IsValid)
            {
                //SessionHelper.SetSession(new AdminSession() { user_name = model.user_name });
                FormsAuthentication.SetAuthCookie(model.user_name, model.RememberMe);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("","Tên đăng nhập hoặc mật khẩu không đúng.");
            }
            return View(model);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}