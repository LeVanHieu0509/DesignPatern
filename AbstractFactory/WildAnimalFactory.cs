using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class WildAnimalFactory : IAnimalFactory
    {
        //Những cái gì chung với nhau như là thú hoang dã thì gom chung lại
        public IDog GetDog()
        {
            return new WildDog();
        }

        public ITiger GetTiger()
        {
            return new WildTiger();
        }
    }
}
