using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationSignalRTest
{
    public class ChatHub:Hub
    {
        public async Task Send(string userName, string message)
        {
            await this.Clients.All.SendAsync("ReceiveMessage", userName, message);
        }
    }
}
