using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolSystem.Controllers
{
    public class StudentController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddStudent()
        {
            return View();
        }
        //public ActionResult AddStudent()
        //{
        //    return View();
        //}
    }
}