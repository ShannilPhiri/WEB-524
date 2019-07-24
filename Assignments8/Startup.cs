using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignments8.Startup))]
namespace Assignments8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
