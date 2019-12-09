using Microsoft.AspNetCore.SignalR;
using MyProject.Data;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Hubs
{
    public class ChatHubs : Hub
    {
        private ApplicationContext _context;
        
        public ChatHubs(ApplicationContext context)
        {
            _context = context;
        }

        public async Task SendMessage(string user, string message)
        {
            var current_comment = new Comment

            {
                Text = message,
                UserName = user
            };
            _context.Comments.Add(current_comment);
            _context.SaveChanges();
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

    }
}
