using BusinessLayer.Concrete;
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
        public ActionResult Index()
        {
            // Bu metot ile ana sayfadaki üst menüden ve footer'dan tıklandığında HAKKIMIZDA sayfasının görüntülenmesi sağlanmaktadır!!!
            return View();
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
            return PartialView();
        }
    }
}