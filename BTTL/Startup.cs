using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BTTL.Startup))]
namespace BTTL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
