using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SyncfusionSamples.Startup))]
namespace SyncfusionSamples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
