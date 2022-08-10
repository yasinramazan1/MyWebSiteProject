using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// Controller'larda amaç şart yazmamaktır, var olan metodu çağırıp çalıştırmaktır!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
namespace yasinramazangokWebSiteProject.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        CommentManager commentManager = new CommentManager();

        [AllowAnonymous]
        public PartialViewResult blogCommentList(int id)
        {
            // Bu metot ile bir bloğa yapılan yorumları görüntüleyebiliyoruz. Bir id'ye göre yorumlar listelenir.
            var commentList = commentManager.commentByBlog(id);
            return PartialView(commentList);
        }

        [AllowAnonymous]
        [HttpGet]
        public PartialViewResult leaveComment(int id)
        {
            // Bu metot ile bir bloğa yorum yapabiliyoruz.
            ViewBag.id = id;
            return PartialView();
        }

        [AllowAnonymous]
        [HttpPost]
        public PartialViewResult leaveComment(Comment c)
        {
            // Bu metot ile bir bloğa yorum yapabiliyoruz.
            c.status = true; // Bir yorum yapıldığında otomatik olarak veri tabanına true kaydedilmesi ve anında blogların altında görülmesi için bu tanım yapıldı.
            commentManager.commentAdd(c);
            return PartialView();
        }

        public ActionResult adminCommentListTrue()
        {
            //Admin panelinde yorumların listelenmesi bu metot ile sağlanmaktadır.
            var commentList = commentManager.commentByStatusTrue();
            return View(commentList);

        }

        public ActionResult adminCommentListFalse()
        {
            //Admin panelinde yorumların listelenmesi bu metot ile sağlanmaktadır.
            var commentList = commentManager.commentByStatusFalse();
            return View(commentList);

        }

        public ActionResult statusChangeToFalse(int id)
        {
            commentManager.commentStatusChangeToFalse(id);
            return RedirectToAction("adminCommentListTrue");
        }

        public ActionResult statusChangeToTrue(int id)
        {
            commentManager.commentStatusChangeToTrue(id);
            return RedirectToAction("adminCommentListFalse");
        }
    }
}