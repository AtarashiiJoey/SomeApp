using Microsoft.Owin;
using Owin;
using SomeAPP;

[assembly:OwinStartup(typeof(Startup))]
namespace SomeAPP
{
    public class Startup
    {
        public void Configuration(IAppBuilder app) => app.MapSignalR();
    }
}