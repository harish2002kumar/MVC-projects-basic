using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // same view name and method name
        public ViewResult About()
        {
            return View();
        }

        // view diff & method diff
        [ActionName("Contacty")]
        public ViewResult Contact()
        {
            return View("ContactUs");
        }

        // using shared folder
        public ViewResult Product()
        {
            return View();
        }

        //displaying from diff controller
        public ViewResult Display()
        {
            return View("~/Views/Account/Dashboard.cshtml");
        }


        public ContentResult result1()
        {
            return Content("hell o everyone");
        }

        public string st()
        {
            return "I'm string";
        }

        public int add()
        {
            int a = 20, b = 10;
           int c=a+b;
            return c;
        }

        // file ressult in view and download file
        public FileResult show()
        {
            return File("~/Content/C#coding.txt","text/plain");
        }

        // file result request to download
        public FileResult dLoad()
        {
            return File(Server.MapPath("~/Content/C#coding.txt"), "text/plain", "cding File");
        }


        public ViewResult list()
        {
           return View();
        }



        public ContentResult detials()
        {
           int x=Convert.ToInt32( Request["id"]);
            string country = "";
            switch (x)
            {
                case 1: country = "india"; break;
                case 2: country = "US"; break;
                default: country = "invild id";
                    break;
            
            }



            return Content(country);
        }



    }
}