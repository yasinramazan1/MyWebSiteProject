using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace yasinramazangokWebSiteProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        [HttpGet]
        public ActionResult authorLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult authorLogin(Author p)
        {
            Context c = new Context();
            var userInfo = c.AUTHORS.FirstOrDefault(x => x.mail == p.mail && x.password == p.password);
            if(userInfo != null)
            {
                FormsAuthentication.SetAuthCookie(userInfo.mail, false);
                Session["mail"] = userInfo.mail.ToString();
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("authorLogin", "Login");
            }
        }
    }
}