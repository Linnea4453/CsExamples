using System;
using System.Collections.Generic;
using System.Text;

namespace C15_Abstract2.Models
{
    abstract class Device
    {
        public virtual string CreateFromConnectionsString(string connectionstring)
        {
            return $"Initalizing connection with \"{connectionstring} \"";
        }
        public abstract string ReciveMessage();
        public abstract void SendMessage(string payload);


    }
}
