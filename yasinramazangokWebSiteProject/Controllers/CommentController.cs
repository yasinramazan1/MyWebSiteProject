using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yasinramazangokWebSiteProject.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        CommentManager commentManager = new CommentManager();
        public PartialViewResult blogCommentList(int id)
        {
            // Bu metot ile bir bloğa yapılan yorumları görüntüleyebiliyoruz.
            var commentList = commentManager.commentByBlog(id);
            return PartialView(commentList);
        }

        [HttpGet]
        public PartialViewResult leaveComment(int id)
        {
            // Bu metot ile bir bloğa yorum yapabiliyoruz.
            ViewBag.id = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult leaveComment(Comment c)
        {
            // Bu metot ile bir bloğa yorum yapabiliyoruz.
            commentManager.commentAdd(c);
            return PartialView();
        }
    }
}