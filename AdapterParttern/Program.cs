using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterParttern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Android android = new Android();
            Iphone iphone = new Iphone();

            Console.WriteLine("Recharging android with MicroUsb");
            rechargeMicroUsbPhone(android);

            Console.WriteLine("Recharging iphone with Lightning");
            rechargeMicroUsbPhone(android);

        }
        static void rechargeLightningPhone(LightningPhone phone)
        {
            phone.useLightning();
            phone.recharge();
        }

        static void rechargeMicroUsbPhone(MicroUsbPhone phone)
        {
            phone.useMicroUsb();
            phone.recharge();
        }

       
    }
}
