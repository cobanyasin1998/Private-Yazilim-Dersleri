using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ChartsAPI.Hubs
{
    public class SatisHub:Hub
    {
        public async Task SendMessageAsync()
        {
            await Clients.All.SendAsync("receiveMessage","Merhaba");
        }
    }
}
