using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace actioncontent_data.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ViewResult list()
        {
            return View();
        }



        public ContentResult detials()
        {
            int x = Convert.ToInt32(Request["id"]);
            string country = "";
            switch (x)
            {
                case 1: country = "india"; break;
                case 2: country = "US"; break;
                default:
                    country = "invild id";
                    break;

            }



            return Content(country);
        }
    }
}