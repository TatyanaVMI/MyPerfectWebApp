using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyPerfectWebApp.Startup))]
namespace MyPerfectWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
