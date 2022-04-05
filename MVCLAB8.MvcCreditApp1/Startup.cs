using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLAB8.MvcCreditApp1.Startup))]
namespace MVCLAB8.MvcCreditApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
