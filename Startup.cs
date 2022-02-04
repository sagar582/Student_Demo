using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Student_Demo.Startup))]
namespace Student_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
