using System.Web.Http;
using log4net.Config;
using VuelingExam.Business.Facade.App_Start;

namespace VuelingExam.Business.Facade
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            XmlConfigurator.Configure();
            AutofacConfig.Configure();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
