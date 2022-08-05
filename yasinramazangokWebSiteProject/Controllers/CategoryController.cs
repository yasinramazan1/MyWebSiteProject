using BusinessLayer.Concrete; // CategoryManager sınıfını BusinessLayer katmanından çağırabilmek için gerekli kütüphane
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yasinramazangokWebSiteProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        CategoryManager categoryManager = new CategoryManager();
        public ActionResult Index()
        {
            // Bu Index metodunun "view"ında biz HTML-CSS kodları ile bu metodun yaptığı işi kullanıcıya sunuyoruz.
            var categoryValues = categoryManager.getAll();
            return View(categoryValues);
        }
    }
}