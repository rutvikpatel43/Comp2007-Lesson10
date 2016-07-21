using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lesson10_MVC.Startup))]
namespace Lesson10_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
