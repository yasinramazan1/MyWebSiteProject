using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using yasinramazangokWebSiteProject.Models;

namespace yasinramazangokWebSiteProject.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            // Grafikler için ana index burasıdır ve Pie grafiği görüntülenir.
            return View();
        }

        public ActionResult visualizeResult()
        {
            // Görselleştirilen yani grafiğe çevrilecek verinin listelenmesini sağlayan metot burasıdır.
            return Json(categoryList(), JsonRequestBehavior.AllowGet);
        }

        public List<Class1> categoryList()
        {
            List<Class1> c = new List<Class1>();
            c.Add(new Class1()
            {
                categoryName = "Yazılım",
                blogCount = 14
            });
            c.Add(new Class1()
            {
                categoryName = "Teknoloji",
                blogCount = 20
            });
            c.Add(new Class1()
            {
                categoryName = "Uzay",
                blogCount = 6
            });
            c.Add(new Class1()
            {
                categoryName = "Havacılık",
                blogCount = 9
            });
            return c;
        }

        public ActionResult visualizeResult2()
        {
            // Görselleştirilen yani grafiğe çevrilecek verinin listelenmesini sağlayan metot burasıdır.
            return Json(blogList(), JsonRequestBehavior.AllowGet);
        }

        public List<Class2> blogList()
        {
            List<Class2> c2 = new List<Class2>();
            using(var c = new Context())
            {
                c2 = c.BLOGS.Select(x => new Class2
                {
                    blogName = x.title,
                    rating =x.blogRating
                }).ToList();
            }
            return c2;
        }

        public ActionResult chart1()
        {
            return View();
        }

        public ActionResult chart2()
        {
            // Column grafiğini bu metot oluşturur.
            return View();
        }
        public ActionResult chart3()
        {
            // Line grafiğini bu metot oluşturur.
            return View();
        }
    }
}