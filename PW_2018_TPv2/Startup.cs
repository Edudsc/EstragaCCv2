using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PW_2018_TPv2.Startup))]
namespace PW_2018_TPv2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
