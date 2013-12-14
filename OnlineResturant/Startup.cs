using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineResturant.Startup))]
namespace OnlineResturant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
