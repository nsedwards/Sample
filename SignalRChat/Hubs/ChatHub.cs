﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string pathToImage)
        {
            Clients.All.addNewImageToPage(name, pathToImage);

        }


    }
}