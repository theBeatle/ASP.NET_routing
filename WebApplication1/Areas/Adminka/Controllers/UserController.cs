using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Areas.Adminka.Controllers
{
    public class UserController : Controller
    {
        // GET: Adminka/User
        public ActionResult Index()
        {
            return View();
        }
    }
}