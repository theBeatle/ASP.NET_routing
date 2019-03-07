using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Areas.Dima.Controllers
{
    public class HomeController : Controller
    {
        // GET: Dima/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}