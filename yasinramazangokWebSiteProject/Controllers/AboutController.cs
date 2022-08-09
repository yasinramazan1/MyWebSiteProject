using BusinessLayer.Concrete;
using EntityLayer.Concrete;
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
        AboutManager aboutManager = new AboutManager();
        public ActionResult Index()
        {
            // Bu metot ile ana sayfadaki üst menüden ve footer'dan tıklandığında HAKKIMIZDA sayfasının görüntülenmesi sağlanmaktadır!!!
            var aboutContent = aboutManager.getAll();
            return View(aboutContent);
        }

        public PartialViewResult footer()
        {
            // Footer'ın partial'ı burasıdır.
            AboutManager aboutManager = new AboutManager();
            var aboutContent1 = aboutManager.getAll();
            return PartialView(aboutContent1);
        }

        public PartialViewResult meetTheTeam()
        {
            // Hakkımızda sayfasındaki takımımızla tanışın bölümünün görüntülenmesi bu metot ile sağlanmaktadır.
            // Hakkımızda sayfasının index bölümünde yazmadık çünkü buradaki bölümü veri tabanında farklı bir tablodan çektiğimiz için.
            AuthorManager authorManager = new AuthorManager();  
            var authorList = authorManager.getAll();
            return PartialView(authorList);
        }

        [HttpGet]
        public ActionResult updateAboutList()
        {
            // Hakkımızda sayfasının admin panelinde güncellenme işlemleri bu metot ile sağlanmaktadır. Yani hakkımızda sayfası yüklendiğin verileri getiren metot budur.
            var aboutList = aboutManager.getAll();
            return View(aboutList);
        }

        [HttpPost]
        public ActionResult updateAbout(About p)
        {
            aboutManager.updateAboutBM(p);
            return RedirectToAction("updateAboutList");
        }
    }
}