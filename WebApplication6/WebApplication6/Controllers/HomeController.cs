using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ViewResult list()
        {
            return View();
        }


        public ContentResult display(int cid)
        {
            return Content(cid.ToString());
        }





        public ContentResult detials(int id)
        {
          
            string country = "";
            switch (id)
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