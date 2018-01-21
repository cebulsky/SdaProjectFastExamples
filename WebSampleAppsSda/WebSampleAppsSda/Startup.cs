using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSampleAppsSda.Startup))]
namespace WebSampleAppsSda
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
