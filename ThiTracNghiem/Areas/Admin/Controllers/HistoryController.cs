using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThiTracNghiem.Areas.Admin.Controllers
{
    public class HistoryController : Controller
    {
        // GET: Admin/History
        public ActionResult Index()
        {
            return View();
        }
    }
}