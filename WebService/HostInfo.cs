using System;

namespace WebService
{
    public class HostInfo
    {
        public DateTime Time { get; set; }

        public string Hostname { get; set; }

        public string IpAddress { get; set; }

        public int TickCount { get; set; }
    }
}
