using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTController.Controllers
{
    public class RedirectController : Controller
    {
        // GET: Redirect
        public RedirectToRouteResult Redi()
        {
            return RedirectToAction("Contact", "Home");
        }
    }
}