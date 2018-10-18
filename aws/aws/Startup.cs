using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aws.Startup))]
namespace aws
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
