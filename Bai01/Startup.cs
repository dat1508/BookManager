using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bai01.Startup))]
namespace Bai01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
