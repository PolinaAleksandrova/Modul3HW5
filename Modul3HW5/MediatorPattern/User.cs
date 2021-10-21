using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW5.MediatorPattern
{
    public class User
    {
        private Mediator _mediator;
        public User(Mediator mediator, string name)
        {
            FirstName = name;
            _mediator = mediator;
            _mediator.MessageGet += Receive;
        }

        public string FirstName { get; set; }

        public void Receive(string message, string sender)
        {
            if (sender != FirstName)
            {
                Console.WriteLine("{0} get '{1}' from {2}", FirstName, message, sender);
            }
        }

        public void Send(string message)
        {
            _mediator.Send(message, FirstName);
        }
    }
}
