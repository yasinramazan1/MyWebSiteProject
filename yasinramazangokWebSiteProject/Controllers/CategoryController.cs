using BusinessLayer.Concrete; // CategoryManager sınıfını BusinessLayer katmanından çağırabilmek için gerekli kütüphane
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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

        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        
        [AllowAnonymous]
        public PartialViewResult categoryListInBlogDetails()
        {
            // Herhangi bir blogtaki sağ tarafta kategorilerin listelenmesi bu metot ile sağlanmaktadır.
            var categoryValues = categoryManager.getList();
            return PartialView(categoryValues);
        }

        public ActionResult adminCategoryList()
        {
            // Admin panelinde kategorilerin listelenmesi ve görüntülenmesi
            var categoryList = categoryManager.getList();
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
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);
            if (results.IsValid)
            {
                categoryManager.TAdd(p);
                return RedirectToAction("adminCategoryList");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }

        [HttpGet]
        public ActionResult categoryEdit(int id)
        {
            // Admin panelinde kategorileri düzenleme
            Category category = categoryManager.getById(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult categoryEdit(Category p)
        {
            // Admin panelinde kategorileri düzenleme
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);
            if (results.IsValid)
            {
                categoryManager.updateT(p);
                return RedirectToAction("adminCategoryList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();      
        }

        public ActionResult changeStatusFalse(int id)
        {
            // Admin panelinde kategorileri pasif yapma
            categoryManager.changeCategoryStatusToFalse(id);
            return RedirectToAction("adminCategoryList");
        }

        public ActionResult changeStatusTrue(int id)
        {
            // Admin panelinde kategorileri aktif yapma
            categoryManager.changeCategoryStatusToTrue(id);
            return RedirectToAction("adminCategoryList");
        }
    }
}