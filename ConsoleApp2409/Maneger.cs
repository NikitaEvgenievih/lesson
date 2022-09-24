using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2409
{
    internal class Maneger : Worker
    {
        public int ClientsCount { get; set; }

        public Maneger(string name, int age, double salary, int clientsCount)
                    : base(name, age, salary)
        {
            Console.WriteLine("Full maneger");
            ClientsCount = clientsCount;
        }
        public Maneger() : base()
        {
            Console.WriteLine("Def maneger");
        }
        public override double GetResultSalary()
        {
            return Salary * ClientsCount;
        }
    }
}
