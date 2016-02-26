using System;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Common.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ShinyTrain.Domain;
using ShinyTrain.Persistence;

namespace ShinyTrain
{
    public class WebApp : System.Web.HttpApplication
    {
        private static readonly Lazy<IShinyDataRepository> ShinyDataRepository = new Lazy<IShinyDataRepository>(() =>
        {
            LogManager.GetLogger<WebApp>().Info("Creating a new, in-memory data repository.");

            return new InMemoryShinyDataRepository();
        });

        public static IShinyDataRepository ShinyData
        {
            get { return ShinyDataRepository.Value; }
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var log = LogManager.GetLogger<WebApp>();
            log.InfoFormat("Staring up...");
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = Server.GetLastError();
            var log = LogManager.GetLogger<WebApp>();
            log.Error(exception);
        }
    }
}