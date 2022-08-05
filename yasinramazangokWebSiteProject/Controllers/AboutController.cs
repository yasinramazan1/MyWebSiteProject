using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yasinramazangokWebSiteProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult footer()
        {
            // Footer'ın partial'ı burasıdır.
            return PartialView();
        }
    }
}