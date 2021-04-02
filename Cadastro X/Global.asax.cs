using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Cadastro_X {
    public class Global : HttpApplication {
        void Application_Start(object sender, EventArgs e) {
            
            // Padroniza Datas para formato americano, para serem inseridas no banco de dados
            /*
            System.Globalization.CultureInfo customCulture = new System.Globalization.CultureInfo("en-US", true);
            customCulture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd h:mm tt";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = customCulture;
            */

            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}