using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace yasinramazangokWebSiteProject
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalFilters.Filters.Add(new AuthorizeAttribute());
            /* Authorize işlemini her sınıfta veya controller'da tek tek de tanımlayabilirdik ancak bu büyük projelerde zordur.
             * Bu yüzden projenin tamamına authorize eklemek için 'GlobalFilters.Filters.Add(new AuthorizeAttribute());' tanımı
             * Global.asax dosyasında bu şekilde tanımlanmalıdır.
             * Ancak bu bütün projeye erişimi kısıtlar, bu yüzden AllowAnonymous attribute'ı erişilmek istenen sayfaya eklenerek 
             * o sayfayı global authorize'dan kısıtlayarak projeye erişimi sağlamış oluruz.
            */
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
