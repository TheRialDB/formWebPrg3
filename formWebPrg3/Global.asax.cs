using formWebPrg3;
using static System.Net.Mime.MediaTypeNames;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web;
using System;

namespace formWebPrg3
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Inicializar el contador de usuarios en la aplicación
            Application["UserCount"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // Incrementar el contador de usuarios cuando inicia una nueva sesión
            Application.Lock();
            Application["UserCount"] = (int)Application["UserCount"] + 1;
            Application.UnLock();
        }
    }
}