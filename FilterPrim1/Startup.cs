using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilterPrim1.Startup))]
namespace FilterPrim1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
