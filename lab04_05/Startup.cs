using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab04_05.Startup))]
namespace lab04_05
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
