using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyParttern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Proxy Pattern Demo.***\n");
            Subject proxy = new Proxy();
            proxy.DoSomeWork();
            Console.ReadKey();
        }
    }
}
