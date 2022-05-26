using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    internal class WhatsAppVideo : IVideoCalling
    {
        public void Call()
        {
            Console.WriteLine("Video call through Whatsappp");
        }
    }
}
