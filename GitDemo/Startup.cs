using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitDemo.Startup))]
namespace GitDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {//Comentario de desarrollo / Modificado en Master
            ConfigureAuth(app);
            //Nuevo comentario
        }
    }
}
