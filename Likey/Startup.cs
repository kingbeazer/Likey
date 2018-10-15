using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Likey.Startup))]
namespace Likey
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
