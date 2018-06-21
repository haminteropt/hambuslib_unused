﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HamBusLib
{
    public class RigBusInfo : UdpCmdPacket
    {
        public DateTime CurrentTime { get; set; }
        public string RigType { get; set; }
        public string Name { get; set; }
        public string host { get; set; }
        public string ip { get; set; }
        public int UdpPort { get; set; }
        public int TcpPort { get; set; }
        public bool sendSyncInfo { get; set; }
        public int MinVersion { get; set; }
        public int MaxVersion { get; set; }
    }
}