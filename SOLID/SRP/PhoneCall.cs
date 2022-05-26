using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class PhoneCall
    {
        public void NormalCall()
        {
            Console.WriteLine("Calling normal");
        }
        public void WhatsAppCall()
        {
            Console.WriteLine("Calling Via Whatsapp");
        }
    }
}
