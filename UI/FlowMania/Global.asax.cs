using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MongoRepository;
using FlowMyFLow;

namespace FlowMania
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            MongoRepository.MongoRepository<Basla> repo = new MongoRepository<Basla>();
            repo.DeleteAll();
            Basla b = new Basla();
            FlowAction a = new FlowAction();
            b.SonrakiEleman = a;
            repo.Add(b);

            var txxx = repo.Where(t => t.Id != null).ToList();

        }
    }
}
