using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ViewResult login()
        {


            return View();
        }

        //[HttpPost]
        // public ContentResult Validate()
        //{

        //    string u = Request["uname"];
        //    string p = Request["pass"];

        //    if (u == "admin" && p == "123")
        //    {
        //        return Content("Welcome");
        //    }
        //    else
        //    {

        //        return Content("login failed");
        //    }
        // }


        public ContentResult Validate( string uname ,string pass)
        {

         

            if (uname == "admin" && pass == "123")
            {
                return Content("Welcome");
            }
            else
            {

                return Content("login failed");
            }
        }

    }
}