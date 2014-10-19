using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebCLient.Startup))]
namespace WebCLient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
