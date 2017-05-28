using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RandomOgGenerator.Startup))]
namespace RandomOgGenerator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
