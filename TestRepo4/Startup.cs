using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestRepo4.Startup))]
namespace TestRepo4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
