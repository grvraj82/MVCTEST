using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTEST.Startup))]
namespace MVCTEST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
