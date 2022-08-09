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
            // Bu metot ile kategorileri listeliyoruz.
            var categoryValues = categoryManager.getAll();
            return View(categoryValues);
        }

        public PartialViewResult categoryListInBlogDetails()
        {
            // Herhangi bir blogtaki sağ tarafta kategorilerin listelenmesi bu metot ile sağlanmaktadır.
            var categoryValues = categoryManager.getAll();
            return PartialView(categoryValues);
        }

        
        public ActionResult adminCategoryList()
        {
            var categoryList = categoryManager.getAll();
            return View(categoryList);
        }
    }
}