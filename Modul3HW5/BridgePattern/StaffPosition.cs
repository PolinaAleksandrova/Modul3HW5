using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul3HW5.BridgePattern.Abstraction;

namespace Modul3HW5.BridgePattern
{
    public class StaffPosition : IPosition
    {
        public void HaveResponsibilities()
        {
            Console.WriteLine("Commit to do certain functions");
        }

        public void PerformResponsibilities()
        {
            Console.WriteLine("Perform certain specified functions");
        }
    }
}
