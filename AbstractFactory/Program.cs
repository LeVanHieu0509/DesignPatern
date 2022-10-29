using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Day la demo Astract Factory Parttern ***");
            IAnimalFactory animalFactory = FactoryProvider.GetAnimalFactory("Wild");
            IDog dog = animalFactory.GetDog();
            dog.Aboutme();

            ITiger tiger = animalFactory.GetTiger();
            tiger.Aboutme();
            Console.WriteLine("******************");

            animalFactory = FactoryProvider.GetAnimalFactory("Pet");
            dog = animalFactory.GetDog();
            dog.Aboutme();

            tiger = animalFactory.GetTiger();
            tiger.Aboutme();
        }
    }
}
