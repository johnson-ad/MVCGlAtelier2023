using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCGlAtelier2023.Startup))]
namespace MVCGlAtelier2023
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
