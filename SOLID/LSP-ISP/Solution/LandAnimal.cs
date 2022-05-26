using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP_ISP.Solution
{
    internal class LandAnimal : IAnimal
    {
        public void Drink()
        {
            Console.WriteLine("Land animal drinks");
        }

        public void Eat()
        {
            Console.WriteLine("Land animal eat");
        }
    }
}
