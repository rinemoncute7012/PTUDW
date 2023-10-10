using BTController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTController.Controllers
{
    public class Stronglybac1Controller : Controller
    {
        public ActionResult stronglyptb1()
        {
            return View(new strongbac1());
        }

        [HttpPost]
        public ActionResult stronglyptb1(strongbac1 model)
        {
            if (ModelState.IsValid)
            {
                if (model.a == 0)
                {
                    if (model.b == 0)
                    {
                        model.kq = "Vô số nghiệm";
                    }
                    else
                    {
                        model.kq = "Vô nghiệm";
                    }
                }
                else
                {
                    model.kq = (-model.b / model.a).ToString();
                }
            }
            return View(model);
        }
    }
}