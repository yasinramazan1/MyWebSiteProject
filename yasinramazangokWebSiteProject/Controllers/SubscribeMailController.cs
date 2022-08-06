using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yasinramazangokWebSiteProject.Controllers
{
    public class SubscribeMailController : Controller
    {
        // GET: SubscribeMail
        [HttpGet]
        public PartialViewResult addMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult addMail(SubscribeMail p)
        {
            SubscribeMailManager subscribeMailManager = new SubscribeMailManager();
            subscribeMailManager.BLAdd(p);
            return PartialView();
        }
    }
}