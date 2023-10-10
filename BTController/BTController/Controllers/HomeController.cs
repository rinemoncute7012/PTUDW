using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Greeting()
        {
            ViewBag.title = "Xin chào HOME";
            return View();
        }
        public ActionResult giaipt() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult giaipt(string i)
        {
            return View();
        }
        public ActionResult giaipt1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult giaipt1(string i)
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}