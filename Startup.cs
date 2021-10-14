using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stored_Procedure_Basic_CRUD.Startup))]
namespace Stored_Procedure_Basic_CRUD
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
