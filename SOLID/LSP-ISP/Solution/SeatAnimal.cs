using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP_ISP.Solution
{
    internal class SeatAnimal : IAnimal, ISeaAnimal
    {
        public void Drink()
        {
            Console.WriteLine("Sea animal drinks");
        }

        public void Eat()
        {
            Console.WriteLine("Sea animal eat");
        }

        public void Swim()
        {
            Console.WriteLine("Sea animal swim");
        }
    }
}
