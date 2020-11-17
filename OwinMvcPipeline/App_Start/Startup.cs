using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OwinMvcPipeline.App_Start.Startup))]

namespace OwinMvcPipeline.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            DebugWriter.Write("OwinStartup::Configuration");
            
            app.Use<DebugOwinMiddleware>();

            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }

    public class DebugOwinMiddleware : OwinMiddleware
    {
        private OwinMiddleware _next;

        public DebugOwinMiddleware(OwinMiddleware next) : base(next)
        {
            _next = next;
        }

        public override async Task Invoke(IOwinContext context)
        {
            DebugWriter.Write("OwinMiddleware:: Incoming");

            await _next.Invoke(context);

            DebugWriter.Write("OwinMiddleware:: Outgoing");
        }
    }

}
