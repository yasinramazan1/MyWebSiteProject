using BusinessLayer.Concrete; // CategoryManager sınıfını BusinessLayer katmanından çağırabilmek için gerekli kütüphane
using EntityLayer.Concrete;
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

        [AllowAnonymous]
        public PartialViewResult categoryListInBlogDetails()
        {
            // Herhangi bir blogtaki sağ tarafta kategorilerin listelenmesi bu metot ile sağlanmaktadır.
            var categoryValues = categoryManager.getAll();
            return PartialView(categoryValues);
        }

        public ActionResult adminCategoryList()
        {
            // Admin panelinde kategorilerin listelenmesi ve görüntülenmesi
            var categoryList = categoryManager.getAll();
            return View(categoryList);
        }

        [HttpGet]
        public ActionResult addCategoryOnAdmin()
        {
            // Admin panelinde yeni kategori ekleme 
            return View();
        }

        [HttpPost]
        public ActionResult addCategoryOnAdmin(Category p)
        {
            // Admin panelinde yeni kategori ekleme 
            categoryManager.categoryAddBL(p);
            return RedirectToAction("adminCategoryList");
        }

        [HttpGet]
        public ActionResult categoryEdit(int id)
        {
            // Admin panelinde kategorileri düzenleme
            Category category = categoryManager.findCategory(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult categoryEdit(Category p)
        {
            // Admin panelinde kategorileri düzenleme
            categoryManager.editCategory(p);
            return RedirectToAction("adminCategoryList");
        }

        public ActionResult changeStatusFalse(int id)
        {
            // Admin panelinde kategorileri pasif yapma
            categoryManager.changeCategoryStatusToFalse(id);
            return RedirectToAction("adminCategoryList");
        }

        public ActionResult changeStatusTrue(int id)
        {
            // Admin panelinde kategorileri pasif yapma
            categoryManager.changeCategoryStatusToTrue(id);
            return RedirectToAction("adminCategoryList");
        }
    }
}