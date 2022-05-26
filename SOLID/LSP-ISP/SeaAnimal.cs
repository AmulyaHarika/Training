using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP_ISP
{
    internal class SeaAnimal : Animal
    {
        public override void Drink()
        {
            Console.WriteLine("Sea animal drinks");
        }

        public override void Eat()
        {
            Console.WriteLine("Sea animal eat");
        }

        public override void Swim()
        {
            Console.WriteLine("Sea animal swim");
        }
    }
}
