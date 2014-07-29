﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.ComponentModel;
using CprBroker.Engine;

namespace CprBroker.DBR
{
    public class DprDiversionServer : TcpServer
    {
        public DbrQueue DbrQueue;

        protected override byte[] ProcessMessage(byte[] message)
        {
            var req = DiversionRequest.Parse(message);
            if (req != null)
            {
                var ret = req.Process(this.DbrQueue.ConnectionString);
                return ret.ToBytes();
            }
            else
            {
                // Invalid request.
                // TODO: Handle invalid request
                return new byte[0];
            }
        }
    }
}