using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheBestWebPage.Startup))]
namespace TheBestWebPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
