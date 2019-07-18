using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutDemo.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public ActionResult AboutUs()
        {
            return View();
        }

        [Route("programs")]
        public ActionResult Programs()
        {
            return View();
        }

    }
}