using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace HuesCluesAndBlazor.Server.Hubs
{
    public class BoardHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}