using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul3HW5.BridgePattern.Abstraction;

namespace Modul3HW5.BridgePattern
{
    public class ExecutivePosition : IPosition
    {
        public void HaveResponsibilities()
        {
            Console.WriteLine("Control the performance of employee functions");
        }

        public void PerformResponsibilities()
        {
            Console.WriteLine("Assign functions to be performed by others");
        }
    }
}
