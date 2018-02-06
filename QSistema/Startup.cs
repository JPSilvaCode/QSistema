using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QSistema.Startup))]
namespace QSistema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
