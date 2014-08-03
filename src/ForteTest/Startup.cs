using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ForteTest.Startup))]
namespace ForteTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
