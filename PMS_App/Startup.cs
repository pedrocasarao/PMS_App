using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PMS_App.Startup))]
namespace PMS_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
