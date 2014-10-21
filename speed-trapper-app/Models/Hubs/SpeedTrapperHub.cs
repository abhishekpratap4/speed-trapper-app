using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SpeedTrapApp.Models.Hubs
{
    public class SpeedTrapperHub: Hub
    {
        public void sendMessageToClient(string name, int speed)
        {

        }
    }
}