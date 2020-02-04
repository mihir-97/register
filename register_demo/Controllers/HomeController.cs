using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace register_demo.Controllers
{
    public class HomeController : Controller
    {
       
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string Register(string firstname, string lastname, string address, string gender, string city, int pincode)
        {
            return "You Are Registered With - " + firstname + ", " + lastname + "," + address + "," + gender + "," + city + "," + pincode;
        }
    }
}