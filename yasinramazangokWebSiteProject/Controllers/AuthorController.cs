using BusinessLayer.Concrete;
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
    public class AuthorController : Controller
    {
        // GET: Author
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        AuthorManager authorManager = new AuthorManager(new EfAuthorDal());

        [AllowAnonymous]
        public PartialViewResult authorAbout(int id)
        {
            // Bu metot ile blog içerisinde sağ tarafta yazar bilgisini görüntülemekteyiz.
            var authorDetails = blogManager.getBlogById(id);
            return PartialView(authorDetails);
        }

        [AllowAnonymous]
        public PartialViewResult authorPopularBlogs(int id) // Parametre olarak girilen id, bloğun id'sidir.
        {
            // Bu metot ile blog içerisinde sağ tarafta yazar bilgisini görüntülemekteyiz.
            var blogAuthorId = blogManager.getList().Where(x => x.id == id).Select(y => y.authorId).FirstOrDefault();
            var authorBlogs = blogManager.getBlogByAuthor(blogAuthorId);
            return PartialView(authorBlogs);
        }

        public ActionResult authorList()
        {
            // Yazar listesini döndüren metot
            var authorLists = authorManager.getList();
            return View(authorLists);
        }

        [HttpGet]
        public ActionResult addNewAuthor() 
        {
            // Yeni yazar ekleme metodu burasıdır.
            return View(); 
        }

        [HttpPost]
        public ActionResult addNewAuthor(Author p)
        {
            // Validator kullanımı
            AuthorValidator authorValidator = new AuthorValidator();
            ValidationResult results = authorValidator.Validate(p);
            if (results.IsValid)
            {

                authorManager.TAdd(p);
                return RedirectToAction("authorList");
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

        [HttpGet]
        public ActionResult authorEdit(int id)
        {
            Author author = authorManager.getById(id);
            return View(author);
        }

        [HttpPost]
        public ActionResult authorEdit(Author p)
        {
            AuthorValidator authorValidator = new AuthorValidator();
            ValidationResult results = authorValidator.Validate(p);
            if (results.IsValid)
            {
                authorManager.updateT(p);
                return RedirectToAction("authorList");
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
    }
}