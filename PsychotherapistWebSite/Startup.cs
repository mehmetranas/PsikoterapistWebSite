using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PsychotherapistWebSite.Startup))]
namespace PsychotherapistWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
