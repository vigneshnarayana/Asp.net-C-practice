using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asp.net_Crud_Operations_Sp.Startup))]
namespace Asp.net_Crud_Operations_Sp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
