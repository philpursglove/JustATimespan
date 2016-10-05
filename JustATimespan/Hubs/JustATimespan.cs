using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace JustATimespan.Hubs
{
    public class JustATimespan : Hub
    {
        private static bool _started;

        public void Buzz(string name)
        {
            Clients.All.sendMessage("STOP");
            Clients.All.sendMessage(name + " buzzed!");
        }

        public void Start()
        {
            _started = true;

            Clients.All.sendMessage("START");
        }

        public void TimeUp()
        {
            _started = false;

            Clients.All.sendMessage("TIMEUP");
        }

    }
}