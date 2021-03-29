using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElevenNoteDemo.Startup))]
namespace ElevenNoteDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
