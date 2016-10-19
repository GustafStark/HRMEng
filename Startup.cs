using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HRMEng.Startup))]
namespace HRMEng
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
