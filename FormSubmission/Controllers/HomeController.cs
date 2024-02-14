using FormSubmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Student()
        {

            List<Student> stdList = new List<Student>();
            Student std = new Student();

            std.ID = "20-12345-2";
            std.Name = "Thanvir Ahmed";
            std.UserName = "thanvirahmed";
            std.Email = "20-12345-2@student.aiub.edu";

            stdList.Add(std);


            return View(stdList);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}