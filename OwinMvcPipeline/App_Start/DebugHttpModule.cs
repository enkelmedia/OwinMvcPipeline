using System;
using System.Diagnostics;
using System.Web;

namespace OwinMvcPipeline.App_Start
{
    public class DebugHttpModule : IHttpModule 
    {
        public void Init(HttpApplication context)
        {
            DebugWriter.Write("DebugHttpModule::Init");
            context.BeginRequest += new EventHandler(OnBeginRequest);
            context.EndRequest += new EventHandler(OnEndRequest);            
            context.LogRequest += new EventHandler(OnLogRequest);
        }

        private void OnBeginRequest(object sender, EventArgs e)
        {
            DebugWriter.Write("DebugHttpModule::OnBeginRequest");
        }

        private void OnEndRequest(object sender, EventArgs e)
        {
            DebugWriter.Write("DebugHttpModule::OnEndRequest");
        }

        private void OnLogRequest(object sender, EventArgs e)
        {
            DebugWriter.Write("DebugHttpModule::OnLogRequest");
        }
       
        public void Dispose()
        {
            DebugWriter.Write("DebugHttpModule::Dispose");
        }
    }
}