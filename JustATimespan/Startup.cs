using Microsoft.Owin;
using Owin;

namespace JustATimespan
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}