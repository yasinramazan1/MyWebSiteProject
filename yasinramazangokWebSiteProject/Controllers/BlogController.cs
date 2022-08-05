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

        BlogManager blogManager = new BlogManager();
        public ActionResult Index()
        {
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