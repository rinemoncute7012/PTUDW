using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTController.Models;

namespace BTController.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ContentResult FindName(int id)
        {
            var student = new List<Student>()
            {
                new Student(1, "Trinh Dang Khoa", "63CNTT_4"),
                new Student(2, "Nguyen Huu Nghia", "63CNTT_4")
            };
            foreach (var x in student)
            {
                if (x.Id == id)
                    return Content(x.Name);
            }
            return Content("Khong thay");
        }
        public ActionResult Find(int id) 
        {
            var student = new List<Student>()
            {
                new Student(1, "Trinh Dang Khoa", "63CNTT_4"),
                new Student(2, "Ly Quoc Anh", "63CNTT_4"),
                new Student(3, "Nguyen Duy Tam", "63CNTT_4")
               
            };
            foreach (var x in student)
            {
                if (x.Id == id)
                {
                    ViewBag.Student = new Student(x.Id, x.Name, x.Class);
                    ViewBag.Check = 1;
                }
            }
            return View();
        }
        public ActionResult Listviewbag() 
        {
            var student1 = new List<Student>()
            {
                new Student(1, "Trinh Dang Khoa", "63CNTT_4"),
                new Student(2, "Ly Quoc Anh", "63CNTT_4"),
                new Student(3, "Nguyen Duy Tam", "63CNTT_4"),
                new Student(4, "Nguyen Van Thanh", "63CNTT_5")

            };
            ViewBag.List1 =  student1;
            ViewBag.List2 = new List<Student>();
            foreach (var x in student1)
            {
                if (x.Class == "63CNTT_4")
                {
                    ViewBag.List2.Add(x);
                }
            }
            return View();
        }
        public ActionResult List()
        {
            var student1 = new List<Student>()
            {
                new Student(1, "Trinh Dang Khoa", "63CNTT_4"),
                new Student(2, "Ly Quoc Anh", "63CNTT_4"),
                new Student(3, "Nguyen Duy Tam", "63CNTT_4"),
                new Student(4, "Nguyen Van Thanh", "63CNTT_5")

            };
            var student2 = new List<Student>();
            foreach (var x in student1)
            {
                if (x.Class == "63CNTT_4")
                {
                    student2.Add(x);
                }
            }
            var multilist = new MultiList();
            multilist.Student1 = student1;
            multilist.Student2 = student2;
            return View(multilist);
        }
        public ActionResult Greeting()
        {
            ViewBag.title = "Xin chào HOME";
            return View();
        }

        public ActionResult StudentWithLayout()
        {
            var student1 = new List<Student>()
            {
                new Student(1, "Trinh Dang Khoa", "63CNTT_4"),
                new Student(2, "Ly Quoc Anh", "63CNTT_4"),
                new Student(3, "Nguyen Duy Tam", "63CNTT_4"),
                new Student(4, "Nguyen Van Thanh", "63CNTT_5")

            };
            ViewBag.List1 = student1;
            ViewBag.List2 = new List<Student>();
            foreach (var x in student1)
            {
                if (x.Class == "63CNTT_4")
                {
                    ViewBag.List2.Add(x);
                }
            }
            return View();
        }
    }
}