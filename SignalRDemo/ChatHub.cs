using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRDemo
{
    public class ChatMessage
    {
        public string Name { get; set; }
        public string Message { get; set; }
    }

    public class ChatHub : Hub
    {
        private static int _count;

        public void SendMessage(ChatMessage message)
        {
            //Context.User.Identity.Name
            Clients.All.SendAsync("NewMessage", message);
        }

        public void NewUser()
        {
            _count++;
            Clients.All.SendAsync("NewCount", new {count = _count});
        }
    }
}
