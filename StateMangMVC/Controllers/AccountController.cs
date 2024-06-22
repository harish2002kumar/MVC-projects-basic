using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateMangMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ViewResult Personal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Personal(string sname,string address,string contact)
        {
            if (sname == "" || address == "" || contact == "")
            {
                ViewBag.msg = "Pls Enter valid info!";
                return View();
            }
            else
            {
                TempData["name"] = sname;

                TempData["address"] = address;
                TempData["contact"] = contact;
                return RedirectToAction("marks");

        }

    }
}