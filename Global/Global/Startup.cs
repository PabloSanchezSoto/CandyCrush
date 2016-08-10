using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Global.Startup))]
namespace Global
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
