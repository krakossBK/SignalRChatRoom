using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using System.Web;

[assembly: OwinStartup(typeof(SignalRChat.Startup))]

namespace SignalRChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var hubConfiguration = new HubConfiguration
            {
                EnableDetailedErrors = true, // https: //docs.microsoft.com/en-us/aspnet/signalr/overview/guide-to-the-api/hubs-api-guide-javascript-client#how-to-handle-errors
                EnableJavaScriptProxies = true,
                EnableJSONP = true
            };
            app.MapSignalR(hubConfiguration);
            GlobalHost.Configuration.MaxIncomingWebSocketMessageSize = null;
        }
    }
}
