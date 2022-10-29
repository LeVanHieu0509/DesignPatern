using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class PetAnimalFactory : IAnimalFactory
    {
        //Những cái gì chung với nhau như là pet thì gom chung lại
        public IDog GetDog()
        {
            return new PetDog();
        }

        public ITiger GetTiger()
        {
            return new PetTiger();
        }
    }
}
