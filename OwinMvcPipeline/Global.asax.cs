using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace OwinMvcPipeline
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DebugWriter.Write("Global.asax::Application_Start");

            AreaRegistration.RegisterAllAreas();

            RouteTable.Routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            DebugWriter.Write("Global.asax::Application_BeginRequest");
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            DebugWriter.Write("Global.asax::Application_EndRequest");
        }
    }
}
