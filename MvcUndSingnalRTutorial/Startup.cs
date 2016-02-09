using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(MvcUndSingnalRTutorial.Startup))]
namespace MvcUndSingnalRTutorial
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}