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
        public void sendSpeed(string name, int speed)
        {
            Clients.All.sendSpeedToTrapper(name, speed);
        }
    }
}