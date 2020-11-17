using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OwinMvcPipeline.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            DebugWriter.Write("HomeController::Ctor");
            
        }

        public ActionResult Index()
        {
            DebugWriter.Write("HomeController::Index");
            
            return View();
        }

    }
}