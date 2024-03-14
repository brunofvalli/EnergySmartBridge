using MQTTnet.Extensions.ManagedClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EnergySmartBridge.Modules
{
    public class ConnectingFailedHandlerCustom : IConnectingFailedHandler
    {
        public Task HandleConnectingFailedAsync(ManagedProcessFailedEventArgs handler)
        {
            var handlerJson = Newtonsoft.Json.JsonConvert.SerializeObject(handler);

            Console.WriteLine($"ConnectingFailedHandlerCustom.HandleConnectingFailedAsync: {handlerJson}");

            return null;   
        }
    }
}
