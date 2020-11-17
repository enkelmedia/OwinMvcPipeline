using System;
using System.Web;

namespace OwinMvcPipeline.App_Start
{
    public class DebugHttpModuleNumber2 : IHttpModule 
    {
        public void Init(HttpApplication context)
        {
            DebugWriter.Write("DebugHttpModuleNumber2::Init");
            context.BeginRequest += new EventHandler(OnBeginRequest);
            context.EndRequest += new EventHandler(OnEndRequest);            
            context.LogRequest += new EventHandler(OnLogRequest);
        }

        private void OnBeginRequest(object sender, EventArgs e)
        {
            DebugWriter.Write("DebugHttpModuleNumber2::OnBeginRequest");
        }

        private void OnEndRequest(object sender, EventArgs e)
        {
            DebugWriter.Write("DebugHttpModuleNumber2::OnEndRequest");
        }

        private void OnLogRequest(object sender, EventArgs e)
        {
            DebugWriter.Write("DebugHttpModuleNumber2::OnLogRequest");
        }
       
        public void Dispose()
        {
            DebugWriter.Write("DebugHttpModuleNumber2::Dispose");
        }
    }
}