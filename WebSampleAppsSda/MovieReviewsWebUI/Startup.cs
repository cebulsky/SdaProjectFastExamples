using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieReviewsWebUI.Startup))]
namespace MovieReviewsWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
