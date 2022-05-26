using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    internal class InstagramVideo : IVideoCalling
    {
        public void Call()
        {
            Console.WriteLine("VideoCall through Instagram");
        }
    }
}
