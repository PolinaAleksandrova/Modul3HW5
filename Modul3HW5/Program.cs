using System;
using Modul3HW5.BridgePattern;
using Modul3HW5.MediatorPattern;

namespace Modul3HW5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Mediator pattern\n");
            var mediator = new Mediator();
            var mary = new User(mediator, "Mary");
            var jane = new User(mediator, "Jane");
            var nik = new User(mediator, "Nik");
            mary.Send("Hi!");
            Console.WriteLine();
            jane.Send("How are you?");
            Console.WriteLine();
            nik.Send("Have a nice day.");
            Console.WriteLine();

            // Повышение до руководящей должности
            Console.WriteLine("Bridge pattern\n");
            Person employee = new Employee(new StaffPosition());
            employee.Work();
            employee.EarnMoney();
            Console.WriteLine();
            employee.Position = new ExecutivePosition();
            employee.Work();
            employee.EarnMoney();

            Console.ReadLine();
        }
    }
}
