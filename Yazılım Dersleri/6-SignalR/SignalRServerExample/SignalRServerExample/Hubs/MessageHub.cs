using Microsoft.AspNetCore.SignalR;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRServerExample.Hubs
{
    public class MessageHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.Caller.SendAsync("getConnectionId",Context.ConnectionId);
        }
        public async Task addGroup(string connectionId, string groupName)
        {
           await Groups.AddToGroupAsync(connectionId, groupName);
        }
        //public async Task SendMessageAsync(string message, IEnumerable<string> connectionIds)
        //{
            public async Task SendMessageAsync(string message,string groupName, IEnumerable<string> connectionIds)
        {
            #region Caller -> Sadece server'a bildirim gönderen client'la iletişim kurar.
            //await Clients.Caller.SendAsync("receiveMessage", message);
            #endregion
            #region All -> Server'a bağlı olan client'lar ile iletişim kurar.
            //await Clients.Caller.SendAsync("receiveMessage", message);
            #endregion
            #region Other -> Server'a bağlı olan client'lar ile (caller hariç) iletişim kurar.
            //await Clients.Others.SendAsync("receiveMessage", message);
            #endregion


            #region Hub Clients Metotları

            #region AllExcept ->Belirtilen clientlar hariç server'a bağlı olan tüm clientlara bildiride bulunur.
            //await Clients.AllExcept(connectionIds).SendAsync("receiveMessage",message);
            #endregion

            #region Client ->Belirtilen client'a bildiride bulunur.
            //await Clients.Client(connectionIds.First()).SendAsync("receiveMessage",message);
            #endregion

            #region Clients ->Belirtilen client'lara bildiride bulunur.
            //await Clients.Clients(connectionIds).SendAsync("receiveMessage",message);
            #endregion


            #region Groups ->Belirtilen gruptaki tüm clientlara bildiride bulunur. Önce gruplar oluşturulmalı ve clientlar gruplara katılmalı
            //await Clients.Group(groupName).SendAsync("receiveMessage",message);
            #endregion

            //await Clients.GroupExcept(groupName,connectionIds).SendAsync("receiveMessage",message);
            #endregion



        }
    }
}
