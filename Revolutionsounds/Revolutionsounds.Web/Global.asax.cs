using System.Web.Http;
using Revolutionsounds.Data.Initializing;

namespace Revolutionsounds.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            DbInitializer.Set();
        }
    }
}
