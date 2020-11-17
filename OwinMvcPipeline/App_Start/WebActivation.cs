using OwinMvcPipeline.App_Start;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(WebActivation), nameof(WebActivation.PreStart))]
[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(WebActivation), nameof(WebActivation.PostStart))]

namespace OwinMvcPipeline.App_Start
{
    public class WebActivation
    {
        public static void PreStart()
        {
            DebugWriter.Write("WebActivator::PreStart");
        }

        public static void PostStart()
        {
            DebugWriter.Write("WebActivator::PostStart");
        }
    }
}