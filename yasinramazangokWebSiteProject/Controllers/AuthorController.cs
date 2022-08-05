using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yasinramazangokWebSiteProject.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public PartialViewResult authorAbout()
        {
            // Bu metot ile blog içerisinde sağ tarafta yazar bilgisini görüntülemekteyiz.
            return PartialView();
        }

        public PartialViewResult authorPopularBlogs()
        {
            // Bu metot ile blog içerisinde sağ tarafta yazar bilgisini görüntülemekteyiz.
            return PartialView();
        }
    }
}