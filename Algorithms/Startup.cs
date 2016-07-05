using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Algorithms.Startup))]
namespace Algorithms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
