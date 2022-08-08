using BusinessLayer.Concrete;
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
        BlogManager blogManager = new BlogManager();
        public PartialViewResult authorAbout(int id)
        {
            // Bu metot ile blog içerisinde sağ tarafta yazar bilgisini görüntülemekteyiz.
            var authorDetails = blogManager.getBlogById(id);
            return PartialView(authorDetails);
        }

        public PartialViewResult authorPopularBlogs(int id) // Parametre olarak girilen id, bloğun id'sidir.
        {
            // Bu metot ile blog içerisinde sağ tarafta yazar bilgisini görüntülemekteyiz.
            var blogAuthorId = blogManager.getAll().Where(x => x.id == id).Select(y=>y.authorId).FirstOrDefault();
            var authorBlogs = blogManager.getBlogByAuthor(blogAuthorId);
            return PartialView(authorBlogs);
        }
    }
}