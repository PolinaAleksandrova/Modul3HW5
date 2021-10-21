using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul3HW5.BridgePattern.Abstraction;

namespace Modul3HW5.BridgePattern
{
    public abstract class Person
    {
        private IPosition _position;
        public Person(IPosition position)
        {
            _position = position;
        }

        public IPosition Position
        {
            set { _position = value; }
        }

        public virtual void Work()
        {
            _position.HaveResponsibilities();
            _position.PerformResponsibilities();
        }

        public abstract void EarnMoney();
    }
}
