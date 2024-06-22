using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateMangMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["Language"] = "Eng";
            TempData["age"] = "12";
            TempData["comp"] = "MS-WIN";

            Session["UserName"] = "admin";

            HttpCookie mycookie = new HttpCookie("Role");
            mycookie.Value = "User";
            mycookie.Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies.Add(mycookie);

            return View();
        }

        public ViewResult about()
        {
            if (Request.Cookies["Role"]!= null)
            {
                ViewBag.msg = Request.Cookies["Role"].Value;
            }
            else
            {
                ViewBag.msg = "cookie expried";
            }

            return View();
        }

        public ViewResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection values) {
            if(values["user"]=="admin" && values["pass"] == "123")
            {
                Session["uname"] = "Admin";
                return RedirectToAction("Personal", "Account");
            }
            else
            {
                ViewBag.msg = "not valis ! login faild";
            }
            return View();
                }
    }
}