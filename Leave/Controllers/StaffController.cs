using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Leave.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult apply_leave()
        {
            return View();
        }


        public ActionResult leave_history()
        {
            return View();
        }

        public ActionResult staff_profile()
        {
            return View();
        }

        public ActionResult view_leave()
        {
            return View();
        }
    }
}