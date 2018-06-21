using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(crud_aspnet.Startup))]
namespace crud_aspnet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
