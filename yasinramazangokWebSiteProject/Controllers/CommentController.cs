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
        public PartialViewResult blogCommentList()
        {
            // Bu metot ile bir bloğa yapılan yorumları görüntüleyebiliyoruz.
            return PartialView();
        }

        public PartialViewResult leaveComment()
        {
            // Bu metot ile bir bloğa yorum yapabiliyoruz.
            return PartialView();
        }
    }
}