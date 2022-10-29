using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Concrete product (WildTiger)
    class WildTiger : ITiger
    {
        public void Aboutme()
        {
            Console.WriteLine("WildTiger: Tui dang Di San.");
        }
    }
}
