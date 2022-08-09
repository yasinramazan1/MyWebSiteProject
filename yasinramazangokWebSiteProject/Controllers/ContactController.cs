using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yasinramazangokWebSiteProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager contactManager = new ContactManager();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult sendMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult sendMessage(Contact p)
        {
            contactManager.BLContactAdd(p);
            return View();
        }

        public ActionResult inbox()
        {
            // Gelen kutusu
            var messageList = contactManager.getAll();
            return View(messageList);
        }

        public ActionResult messageDetails(int id)
        {
            Contact contact = contactManager.getMessageDetails(id);
            return View(contact);
        }
    }
}