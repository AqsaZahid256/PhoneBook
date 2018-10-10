using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SE_Lab.Startup))]
namespace SE_Lab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
