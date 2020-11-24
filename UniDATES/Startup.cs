using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniDATES.Startup))]
namespace UniDATES
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
