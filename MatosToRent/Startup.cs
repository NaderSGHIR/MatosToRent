using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MatosToRent.Startup))]
namespace MatosToRent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
