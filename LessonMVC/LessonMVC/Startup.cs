using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LessonMVC.Startup))]
namespace LessonMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
