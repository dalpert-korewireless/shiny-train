using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.UI.WebControls;
using System.Web.WebPages;
using Common.Logging;

namespace ShinyTrain
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode,
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //RouteTable.Routes.MapHubs();                                // marked Obselete; consider using OWIN alternative
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var log = LogManager.GetLogger<MvcApplication>();
            log.InfoFormat("Staring up...");
            Crier.Start();
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = Server.GetLastError();
            var log = LogManager.GetLogger<MvcApplication>();
            log.Error(exception);
        }

        public override void Dispose()
        {
            var log = LogManager.GetLogger<MvcApplication>();
            log.InfoFormat("Shutting down...");
            Crier.Stop();
            base.Dispose();
        }
    }
}