using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yasinramazangokWebSiteProject.Controllers
{
    public class BlogController : Controller
    {
        // Bu controller'da projenin ana sayfasının kodları yer almaktadır yani ana index burasıdır.
        // GET: Blog
        // ViewBag komutu controller'dan view'lara bir değer taşınmak istendiği zaman kullanılan C#-MVC komutudur.

        BlogManager blogManager = new BlogManager();
        public ActionResult Index()
        {
            // Ana index bu metodun view'ıdır.
            return View();
        }

        public PartialViewResult blogList()
        {
            // Blogların ana sayfada listelendiği ana partial burasıdır.
            // Manager sınıflarında tanımlanan metotlar buradaki metotlar içerisinde çağırılabilir.
            var blogList = blogManager.getAll();
            return PartialView(blogList);
        }

        public PartialViewResult featuredBlogs()
        {
            // Öne çıkan blogların listelendiği partial burasıdır.           
            // Öne Çıkan Bloglarda 1. Blog
            var blogTitle1 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 1).Select(y => y.title).FirstOrDefault(); // Bu tanımlama kategori id'si 1 olan blog title'lar içerisindeki ilk bloğun başlığını getirir.
            var blogImage1 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 1).Select(y => y.image).FirstOrDefault();
            var blogDate1 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 1).Select(y => y.date).FirstOrDefault();
            ViewBag.blogTitle1 = blogTitle1; // ViewBag.'dan sonra bir değişkene isim verir gibi viewbag'e isim veririz. 
            ViewBag.blogImage1 = blogImage1;
            ViewBag.blogDate1 = blogDate1;            

            // Öne Çıkan Bloglarda 2. Blog
            var blogTitle2 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 2).Select(y => y.title).FirstOrDefault();
            var blogImage2 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 2).Select(y => y.image).FirstOrDefault();
            var blogDate2 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 2).Select(y => y.date).FirstOrDefault();
            ViewBag.blogTitle2 = blogTitle2; // ViewBag.'dan sonra bir değişkene isim verir gibi viewbag'e isim veririz. 
            ViewBag.blogImage2 = blogImage2;
            ViewBag.blogDate2 = blogDate2;

            // Öne Çıkan Bloglarda 3. Blog
            var blogTitle3 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 3).Select(y => y.title).FirstOrDefault();
            var blogImage3 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 3).Select(y => y.image).FirstOrDefault();
            var blogDate3 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 3).Select(y => y.date).FirstOrDefault();
            ViewBag.blogTitle3 = blogTitle3; // ViewBag.'dan sonra bir değişkene isim verir gibi viewbag'e isim veririz. 
            ViewBag.blogImage3 = blogImage3;
            ViewBag.blogDate3 = blogDate3;

            // Öne Çıkan Bloglarda 2. Blog
            var blogTitle4 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 4).Select(y => y.title).FirstOrDefault();
            var blogImage4 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 4).Select(y => y.image).FirstOrDefault();
            var blogDate4 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 4).Select(y => y.date).FirstOrDefault();
            ViewBag.blogTitle4 = blogTitle4; // ViewBag.'dan sonra bir değişkene isim verir gibi viewbag'e isim veririz. 
            ViewBag.blogImage4 = blogImage4;
            ViewBag.blogDate4 = blogDate4;

            // Öne Çıkan Bloglarda Ortadaki Büyük Blog
            var blogTitle5 = blogManager.getAll().Where(x => x.category.id == 1).Select(y => y.title).FirstOrDefault();
            var blogImage5 = blogManager.getAll().Where(x => x.category.id == 1).Select(y => y.image).FirstOrDefault();
            var blogDate5 = blogManager.getAll().Where(x => x.category.id == 1).Select(y => y.date).FirstOrDefault();
            ViewBag.blogTitle5 = blogTitle5; // ViewBag.'dan sonra bir değişkene isim verir gibi viewbag'e isim veririz. 
            ViewBag.blogImage5 = blogImage5;
            ViewBag.blogDate5 = blogDate5;
            return PartialView();
        }
        public PartialViewResult otherFeaturedBlogs()
        {
            // Footer'ın hemen üzerinde öne çıkan blogların listelendiği partial burasıdır.
            return PartialView();
        }

        public PartialViewResult mailSubscribe()
        {
            // Footer'ın hemen üzerinde mail aboneliğinin partial'ı burasıdır.
            return PartialView();
        }



        public ActionResult blogDetails()
        {
            // Bu metodun view'ı Blog'larda olduğu gibi ana index görevi görmektedir. Yani bütün partial'ların toplandığı view'dır.
            return View();
        }

        public PartialViewResult blogCover()
        {
            return PartialView();
        }

        public PartialViewResult readAllBlog()
        {
            // Bir bloğun yazısının hepsini görüntüleme yani bloğu görüntüleme bu metot üzerinde çalışmaktadır.
            return PartialView();
        }

        public ActionResult blogByCategory()
        {
            // Üst menü ve footer'daki kategorilere tıklandığında o kategorinin bloglarının görüntülenmesi yani kategori detay sayfası bu metot ile sağlanmaktadır. 
            return View();
        }




    }
}