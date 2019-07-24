using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignments9.Startup))]
namespace Assignments9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
