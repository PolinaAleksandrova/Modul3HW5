using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW5.MediatorPattern
{
    public delegate void MessageGetEventHandler(string message, string sender);
    public class Mediator
    {
        public event MessageGetEventHandler MessageGet;
        public void Send(string message, string sender)
        {
            if (MessageGet != null)
            {
                Console.WriteLine("Sending '{0}' from {1}", message, sender);
                MessageGet(message, sender);
            }
        }
    }
}
