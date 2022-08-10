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
    [AllowAnonymous] // Bu attribute ile sadece LoginController içindeki metotlar global authorize'dan etkilenmeyecektir.
    public class LoginController : Controller
    {
        // GET: Login

        [HttpGet]
        public ActionResult authorLogin()
        {
            // Yazar giriş ekranı burasıdır.
            return View();
        }

        [HttpPost]
        public ActionResult authorLogin(Author p)
        {
            // Yazar giriş ekranı oturum açma işlemleri buradan yapılıyor.
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

        [HttpGet]
        public ActionResult adminLogin()
        {
            // Yönetici giriş ekranı burasıdır.
            return View();
        }

        [HttpPost]
        public ActionResult adminLogin(Admin p)
        {
            // Yazar giriş ekranı oturum açma işlemleri buradan yapılıyor.
            Context c = new Context();
            var adminInfo = c.ADMINS.FirstOrDefault(x => x.userName == p.userName && x.password == p.password);
            if (adminInfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminInfo.userName, false);
                Session["userName"] = adminInfo.userName.ToString();
                return RedirectToAction("adminBlogList", "Blog");
            }
            else
            {
                return RedirectToAction("adminLogin", "Login");
            }
        }
    }
}