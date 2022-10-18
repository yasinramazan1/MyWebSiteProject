using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yasinramazangokWebSiteProject.Controllers
{
    [AllowAnonymous]
    public class SubscribeMailController : Controller
    {
        SubscribeMailManager subscribeMailManager = new SubscribeMailManager(new EfMailDal());

        // GET: SubscribeMail
        [HttpGet]
        public PartialViewResult addMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult addMail(SubscribeMail p)
        {
           
            subscribeMailManager.TAdd(p);
            return PartialView();
        }
    }
}