using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsumingExternalAPI.Startup))]
namespace ConsumingExternalAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
