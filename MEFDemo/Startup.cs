using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MEFDemo.Startup))]
namespace MEFDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
