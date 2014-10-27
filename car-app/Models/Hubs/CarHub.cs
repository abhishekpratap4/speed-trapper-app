using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace CarApp.Hubs
{
    public class CarHub: Hub
    {
        public void SendSpeed(string name, int speed)
        {
            Clients.Caller.sendSpeedToTrapper(name, speed);
        }
    }
}