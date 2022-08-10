using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace yasinramazangokWebSiteProject.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        UserProfileManager userProfile = new UserProfileManager();
        BlogManager blogManager = new BlogManager();
        // GET: User
        public ActionResult Index()
        { 
            return View();
        }

        public PartialViewResult partial1(string p)
        {
            // Bu metot ile sisteme authentication olan kişinin bilgilerin getiriyoruz.
            var mail = (string)Session["mail"];
            var profileValues = userProfile.getAuthorByMail(mail);
            return PartialView(profileValues);
        }

        public ActionResult updateAuthorProfile(Author p)
        {
            userProfile.editAuthor(p);
            return RedirectToAction("Index");
        }

        public ActionResult authorBlogList(string p)
        {
            // Admin panelinde yazarların kendi sayfasında bloglarını görüntüleyen metot burasıdır.
            p = (string)Session["mail"];
            Context c = new Context();
            int id = c.AUTHORS.Where(x => x.mail == p).Select(y => y.id).FirstOrDefault();
            var blogs = userProfile.getBlogsByAuthor(id);
            return View(blogs);
        }

        [HttpGet]
        public ActionResult updateBlogAdmin(int id)
        {
            // Blogların güncelleme işlemi bu metot ile yapılmaktadır.
            Blog blog = blogManager.findBlog(id);

            Context c = new Context();
            List<SelectListItem> values = (from x in c.CATEGORIES.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.name,
                                               Value = x.id.ToString()
                                           }).ToList();
            ViewBag.values = values;
            List<SelectListItem> values2 = (from x in c.AUTHORS.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.name,
                                                Value = x.id.ToString()
                                            }).ToList();
            ViewBag.values2 = values2;
            return View(blog);
        }

        [HttpPost]
        public ActionResult updateBlogAdmin(Blog p)
        {
            blogManager.updateBlog(p);
            return RedirectToAction("authorBlogList");
        }

        [HttpGet]
        public ActionResult addNewBlogAdmin()
        {
            // Admin panelinde yeni blok ekleme işlemi için bu metot kullanılır.
            Context c = new Context();
            List<SelectListItem> values = (from x in c.CATEGORIES.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.name,
                                               Value = x.id.ToString()
                                           }).ToList();
            ViewBag.values = values;
            List<SelectListItem> values2 = (from x in c.AUTHORS.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.name,
                                                Value = x.id.ToString()
                                            }).ToList();
            ViewBag.values2 = values2;
            return View();
        }
        [HttpPost]
        public ActionResult addNewBlogAdmin(Blog b)
        {
            blogManager.blogAddBL(b);
            return RedirectToAction("authorBlogList");
            // adminBlogList, admin panelinin index sayfası olduğu için o sayfaya yönlendiriyoruz.
        }

        public ActionResult logOut()
        {
            // Sisteme authentication olan admin veya yazarlar için çıkış yapma işlemi 
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("authorLogin", "Login");
        }

    }
}