using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class WildDog : IDog
    {
        public void Aboutme()
        {
            Console.WriteLine("WildDog: Toi thich tu do, Bow-Bow");
        }
    }
}
