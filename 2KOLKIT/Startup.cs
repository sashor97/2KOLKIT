using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2KOLKIT.Startup))]
namespace _2KOLKIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
