using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul3HW5.BridgePattern.Abstraction;

namespace Modul3HW5.BridgePattern
{
    public class Employee : Person
    {
        public Employee(IPosition position)
    : base(position)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Receive a monthly salary");
        }
    }
}
