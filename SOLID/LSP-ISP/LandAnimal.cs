using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP_ISP
{
    internal class LandAnimal : Animal
    {
        public override void Drink()
        {
            Console.WriteLine("Land animal drinks");
        }

        public override void Eat()
        {
            Console.WriteLine("Land animal eat");
        }
        public override void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
