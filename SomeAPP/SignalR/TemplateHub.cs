using Microsoft.AspNet.SignalR;

namespace SomeAPP.SignalR
{
    public class TemplateHub : Hub
    {
        public void Announce(string message) => Clients.All.Announce(message);
    }
}