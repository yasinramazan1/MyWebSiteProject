using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yasinramazangokWebSiteProject.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        // GET: About
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            // Bu metot ile ana sayfadaki üst menüden ve footer'dan tıklandığında HAKKIMIZDA sayfasının görüntülenmesi sağlanmaktadır!!!
            var aboutContent = aboutManager.getList();
            return View(aboutContent);
        }

        public PartialViewResult footer()
        {
            // Footer'ın partial'ı burasıdır.
            var aboutContent1 = aboutManager.getList();
            return PartialView(aboutContent1);
        }

        public PartialViewResult meetTheTeam()
        {
            // Hakkımızda sayfasındaki takımımızla tanışın bölümünün görüntülenmesi bu metot ile sağlanmaktadır.
            // Hakkımızda sayfasının index bölümünde yazmadık çünkü buradaki bölümü veri tabanında farklı bir tablodan çektiğimiz için.
            AuthorManager authorManager = new AuthorManager(new EfAuthorDal());  
            var authorList = authorManager.getList();
            return PartialView(authorList);
        }

        [HttpGet]
        public ActionResult updateAboutList()
        {
            // Hakkımızda sayfasının admin panelinde güncellenme işlemleri bu metot ile sağlanmaktadır. Yani hakkımızda sayfası yüklendiğin verileri getiren metot budur.
            var aboutList = aboutManager.getList();
            return View(aboutList);
        }

        [HttpPost]
        public ActionResult updateAbout(About p)
        {
            aboutManager.updateT(p);
            return RedirectToAction("updateAboutList");
        }
    }
}