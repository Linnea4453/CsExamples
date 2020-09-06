using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace C15_Abstract2.Models
{
    class TempSensor : Device
    {
        public override string CreateFromConnectionsString(string connectionstring)
        {
            var response = base.CreateFromConnectionsString(connectionstring);
            response += "- Device connected";
            return response;
        }


        public override string ReciveMessage()
        {
            var message = JsonConvert.DeserializeObject<dynamic>("{ \"command\" : \"get\"  }");
            return message.command;
        }

        public override void SendMessage(string payload)
        {
            Console.WriteLine($"Sending message: {payload} ");
        }
    }
}
