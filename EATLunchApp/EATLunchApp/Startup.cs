using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EATLunchApp.Startup))]
namespace EATLunchApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
