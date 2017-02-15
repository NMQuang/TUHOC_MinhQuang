using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguoiDungWeb.Startup))]
namespace NguoiDungWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
