using System;
using System.Diagnostics;
using System.Web;

namespace OwinMvcPipeline
{

    public static class DebugWriter
    {
        public static void Write(string message)
        {
            Debug.WriteLine($"---------- {message} ---- {HttpContextStatus.Status}  ");
        }
    }

    public static class HttpContextStatus
    {
        public static string Status
        {
            get
            {
                if (HttpContext.Current == null)
                    return "NoHttpContext";

                try
                {
                    if (HttpContext.Current.Request == null)
                        return "NoHttpContextRequest";
                }
                catch (Exception e)
                {
                    return "HttpContextNoRequest";
                }

                return $"HttpContextWithRequest ({HttpContext.Current.Request.Url.PathAndQuery})";

            }
        }
    }
}