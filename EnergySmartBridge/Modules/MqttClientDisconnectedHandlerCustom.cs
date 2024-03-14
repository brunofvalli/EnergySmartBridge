using MQTTnet.Client.Disconnecting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EnergySmartBridge.Modules
{
    internal class MqttClientDisconnectedHandlerCustom : IMqttClientDisconnectedHandler
    {
        public Task HandleDisconnectedAsync(MqttClientDisconnectedEventArgs handler)
        {
            var handlerJson = Newtonsoft.Json.JsonConvert.SerializeObject(handler);

            Console.WriteLine($"ConnectingFailedHandlerCustom.HandleConnectingFailedAsync: {handlerJson}");

            return null;
        }
    }
}
