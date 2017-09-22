using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PayrollMVC.Startup))]
namespace PayrollMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
