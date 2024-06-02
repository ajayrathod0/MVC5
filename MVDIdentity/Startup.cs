using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVDIdentity.Startup))]
namespace MVDIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
