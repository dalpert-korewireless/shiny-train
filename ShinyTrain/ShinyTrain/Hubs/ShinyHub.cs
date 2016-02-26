using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.Logging;
using Microsoft.AspNet.SignalR;

namespace ShinyTrain.Hubs
{
    public class ShinyHub : Hub
    {
        /// <summary>
        /// Pushes content to clients
        /// </summary>
        /// <param name="name"></param>
        /// <param name="message"></param>
        public void Send(string name, string message)
        {
            LogManager.GetLogger<ShinyHub>().InfoFormat("Sending: {0} | {1}", name, message);
            var shinyHub = GlobalHost.ConnectionManager.GetHubContext<ShinyHub>();
            shinyHub.Clients.All.addNewMessageToPage(name, message);
        }
    }
}