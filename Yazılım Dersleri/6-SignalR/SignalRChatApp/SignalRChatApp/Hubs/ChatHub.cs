using Microsoft.AspNetCore.SignalR;
using SignalRChatApp.Data;
using SignalRChatApp.Models;
using System.Threading.Tasks;

namespace SignalRChatApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task GetNickName(string nickName)
        {
            Client client = new Client()
            {
                ConnectionId = Context.ConnectionId,
                NickName = nickName
            };

            ClientSource.Clients.Add(client);
            await Clients.Others.SendAsync("clientJoined",nickName);
        }
    }
}
