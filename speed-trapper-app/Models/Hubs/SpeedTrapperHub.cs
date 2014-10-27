using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using SpeedTrapApp.Controllers;

namespace SpeedTrapApp.Models.Hubs
{
    public class SpeedTrapperHub: Hub
    {
        static string connId;
        public void sendCarDetails(string name, int speed)
        {
            int flag = 0;
            if (speed > HomeController.speedLimit)
            {
                Clients.Caller.showBustedMessage();
                flag = 1;
            }
            var Context = GlobalHost.ConnectionManager.GetHubContext<SpeedTrapperHub>();
            Context.Clients.Client(connId).showCarOnSpeedTracker(name, speed, flag);
        }
        public void initialize() {
            connId = Context.ConnectionId;
        }
    }
}