using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yasinramazangokWebSiteProject.Controllers
{
    public class BlogController : Controller
    {
        // Bu controller'da projenin ana sayfasının kodları yer almaktadır yani ana index burasıdır.
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }
        
        public PartialViewResult blogList()
        {
            // Blogların ana sayfada listelendiği ana partial burasıdır.
            return PartialView();
        }

        public PartialViewResult featuredBlogs()
        {
            // Öne çıkan blogların listelendiği partial burasıdır.
            return PartialView();
        }
        public PartialViewResult otherFeaturedBlogs()
        {
            // Footer'ın hemen üzerinde öne çıkan blogların listelendiği partial burasıdır.
            return PartialView();
        }

        public PartialViewResult mailSubscribe()
        {
            // Footer'ın hemen üzerinde mail aboneliğinin partial'ı burasıdır.
            return PartialView();
        }





    }
}