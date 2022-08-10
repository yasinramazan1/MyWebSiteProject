using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using PagedList;
using PagedList.Mvc;
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

        [AllowAnonymous]
        public ActionResult Index()
        {
            // Ana index bu metodun view'ıdır.
            return View();
        }

        [AllowAnonymous]
        public PartialViewResult blogList(int page = 1)
        {
            // Blogların ana sayfada listelendiği ana partial burasıdır.
            // Manager sınıflarında tanımlanan metotlar buradaki metotlar içerisinde çağırılabilir.
            // PagedList ve PagedList.Mvc kütüphaneleri listeleme işlemine yardımcı olan kütüphanelerdir.
            var blogList = blogManager.getAll().ToPagedList(page, 6); // Toplam veriyi ikinci parametreye böler ve sayfalar oluşur ve ilk parametre kaçıncı sayfadan başlayacağını bildirir. İkinci parametre ise bir sayfada kaç tane veri listeleneceğini bildirir.
            return PartialView(blogList);
        }

        [AllowAnonymous]
        public PartialViewResult featuredBlogs()
        {
            // Ana sayfada üstte öne çıkan blogların listelendiği partial burasıdır.           
            // Öne Çıkan Bloglarda 1. Blog
            var blogTitle1 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 1).Select(y => y.title).FirstOrDefault(); // Bu tanımlama kategori id'si 1 olan blog title'lar içerisindeki ilk bloğun başlığını getirir.
            var blogImage1 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 1).Select(y => y.image).FirstOrDefault();
            var blogDate1 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 1).Select(y => y.date).FirstOrDefault();
            var blogId1 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 1).Select(y => y.id).FirstOrDefault();
            ViewBag.blogTitle1 = blogTitle1; // ViewBag.'dan sonra bir değişkene isim verir gibi viewbag'e isim veririz. 
            ViewBag.blogImage1 = blogImage1;
            ViewBag.blogDate1 = blogDate1;
            ViewBag.blogId1 = blogId1; // Bu viewbag ana sayfada link görevi görmektedir! 

            // Öne Çıkan Bloglarda 2. Blog
            var blogTitle2 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 2).Select(y => y.title).FirstOrDefault();
            var blogImage2 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 2).Select(y => y.image).FirstOrDefault();
            var blogDate2 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 2).Select(y => y.date).FirstOrDefault();
            var blogId2 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 2).Select(y => y.id).FirstOrDefault();
            ViewBag.blogTitle2 = blogTitle2; // ViewBag.'dan sonra bir değişkene isim verir gibi viewbag'e isim veririz. 
            ViewBag.blogImage2 = blogImage2;
            ViewBag.blogDate2 = blogDate2;
            ViewBag.blogId2 = blogId2;

            // Öne Çıkan Bloglarda 3. Blog
            var blogTitle3 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 3).Select(y => y.title).FirstOrDefault();
            var blogImage3 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 3).Select(y => y.image).FirstOrDefault();
            var blogDate3 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 3).Select(y => y.date).FirstOrDefault();
            var blogId3 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 3).Select(y => y.id).FirstOrDefault();
            ViewBag.blogTitle3 = blogTitle3; // ViewBag.'dan sonra bir değişkene isim verir gibi viewbag'e isim veririz. 
            ViewBag.blogImage3 = blogImage3;
            ViewBag.blogDate3 = blogDate3;
            ViewBag.blogId3 = blogId3;

            // Öne Çıkan Bloglarda 2. Blog
            var blogTitle4 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 4).Select(y => y.title).FirstOrDefault();
            var blogImage4 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 4).Select(y => y.image).FirstOrDefault();
            var blogDate4 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 4).Select(y => y.date).FirstOrDefault();
            var blogId4 = blogManager.getAll().OrderByDescending(z => z.id).Where(x => x.category.id == 4).Select(y => y.id).FirstOrDefault();
            ViewBag.blogTitle4 = blogTitle4; // ViewBag.'dan sonra bir değişkene isim verir gibi viewbag'e isim veririz. 
            ViewBag.blogImage4 = blogImage4;
            ViewBag.blogDate4 = blogDate4;
            ViewBag.blogId4 = blogId4;

            // Öne Çıkan Bloglarda Ortadaki Büyük Blog
            var blogTitle5 = blogManager.getAll().Where(x => x.category.id == 1).Select(y => y.title).FirstOrDefault();
            var blogImage5 = blogManager.getAll().Where(x => x.category.id == 1).Select(y => y.image).FirstOrDefault();
            var blogDate5 = blogManager.getAll().Where(x => x.category.id == 1).Select(y => y.date).FirstOrDefault();
            var blogId5 = blogManager.getAll().Where(x => x.category.id == 1).Select(y => y.id).FirstOrDefault();
            ViewBag.blogTitle5 = blogTitle5; // ViewBag.'dan sonra bir değişkene isim verir gibi viewbag'e isim veririz. 
            ViewBag.blogImage5 = blogImage5;
            ViewBag.blogDate5 = blogDate5;
            ViewBag.blogId5 = blogId5;
            return PartialView();
        }

        [AllowAnonymous]
        public PartialViewResult otherFeaturedBlogs()
        {
            // Footer'ın hemen üzerinde öne çıkan blogların listelendiği partial burasıdır.
            return PartialView();
        }
        //public PartialViewResult mailSubscribe()
        //{
        //    // Footer'ın hemen üzerinde mail aboneliğinin partial'ı burasıdır.
        //    return PartialView();
        //}

        [AllowAnonymous]
        public ActionResult blogDetails()
        {
            // Bu metodun view'ı Blog'larda olduğu gibi ana index görevi görmektedir. Yani bütün partial'ların toplandığı view'dır.
            return View();
        }

        [AllowAnonymous]
        public PartialViewResult blogCover(int id)
        {
            var blogDetailsList = blogManager.getBlogById(id);
            return PartialView(blogDetailsList);
        }

        [AllowAnonymous]
        public PartialViewResult readAllBlog(int id)
        {
            // Bir bloğun yazısının hepsini görüntüleme yani bloğu görüntüleme bu metot üzerinde çalışmaktadır.
            // var blogDetailsList = blogManager.blogById(id); // Expression Delegate kullanmadan önceki metot budur.
            var blogDetailsList = blogManager.getBlogById(id);
            return PartialView(blogDetailsList);
        }

        [AllowAnonymous]
        public ActionResult blogByCategory(int id)
        {
            // Üst menü ve footer'daki kategorilere tıklandığında o kategorinin bloglarının görüntülenmesi yani kategori detay sayfası bu metot ile sağlanmaktadır. 
            var blogListByCategory = blogManager.getBlogByCategory(id);
            var categoryName = blogManager.getBlogByCategory(id).Select(y => y.category.name).FirstOrDefault();
            ViewBag.categoryName = categoryName;
            var categoryDescription = blogManager.getBlogByCategory(id).Select(y => y.category.description).FirstOrDefault();
            ViewBag.categoryDescription = categoryDescription;
            return View(blogListByCategory);
        }

        // [Authorize] attribute'ını normalde burada kullanmıştık ama proje bazında authorize yaptığımız için kaldırdık.
        public ActionResult adminBlogList()
        {
            // Bu metot ile admin panelinde bloglar listelenebiliyor.
            var blogList = blogManager.getAll();
            return View(blogList);
        }

        public ActionResult adminBlogList2()
        {
            // Bu metot ile admin panelinde bloglar listelenebiliyor.
            var blogList = blogManager.getAll();
            return View(blogList);
        }

        [Authorize(Roles ="A")] // Bu tanımlama ile artık addNewBlog'a rolü A olan adminler erişebilecektir.
        [HttpGet]
        public ActionResult addNewBlog()
        {
            // Admin panelinde yeni blok ekleme
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
        public ActionResult addNewBlog(Blog b)
        {
            blogManager.blogAddBL(b);
            return RedirectToAction("adminBlogList");
            // adminBlogList, admin panelinin index sayfası olduğu için o sayfaya yönlendiriyoruz.
        }

        public ActionResult deleteBlog(int id)
        {
            // id'ye göre bloğu silme
            // Bu metodun bir partial'ı yoktur çünkü zaten silinme işlemi yapıldığında yine blog listesi görüntülenecektir. O yüzden aşağıda da "adminBlogList"e yönlendirdik.
            blogManager.deleteBlogBL(id);
            return RedirectToAction("adminBlogList"); // adminBlogList'e gitmesinin sebebi adminBlogList'in admin panelinin ana indexi görevini görüyor olmasıdır.
        }

        [HttpGet]
        public ActionResult updateBlog(int id)
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
        public ActionResult updateBlog(Blog p)
        {
            blogManager.updateBlog(p);
            return RedirectToAction("adminBlogList");
        }

         public ActionResult getCommentByBlog(int id)
        {
            // Bloğa göre yorum getirme işlemi bu metot ile sağlanmaktadır.
            CommentManager categoryManager = new CommentManager();    
            var commentList = categoryManager.commentByBlog(id);
            return View(commentList);
        }

        public ActionResult authorBlogList(int id)
        {
            // Admin panelinde yazarların kendi sayfasında bloglarını görüntüleyen metot burasıdır.          
            var blogs = blogManager.getBlogByAuthor(id);
            return View(blogs);
        }
    }
}