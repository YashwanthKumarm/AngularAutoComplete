using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoCompleteMVC.Startup))]
namespace AutoCompleteMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
