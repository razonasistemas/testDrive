using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GTP_testDrive.Startup))]
namespace GTP_testDrive
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
