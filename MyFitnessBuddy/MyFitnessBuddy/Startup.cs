using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFitnessBuddy.Startup))]
namespace MyFitnessBuddy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
