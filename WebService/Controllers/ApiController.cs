using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<HostInfo> Get()
        {
            HostInfo hostInfo = new HostInfo
            {
                Time = DateTime.Now,
                Hostname = Dns.GetHostName(),
                TickCount = Environment.TickCount
            };

            IPHostEntry host = Dns.GetHostEntry(hostInfo.Hostname);
            hostInfo.IpAddress = host.AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString();

            return hostInfo;
        }
    }
}
