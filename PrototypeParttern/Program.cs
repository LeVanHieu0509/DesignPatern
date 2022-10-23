using PrototypeParttern.RaiGenicsParttern;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeParttern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //client
            Console.WriteLine("***Prototype Pattern Demo***\n");
            // Base or Original Copy
            BasicCar nano = new Nano("Green Nano");
            BasicCar ford = new Ford("ford Nano");
            BasicCar basicCar;
            //nano
            basicCar = nano.Clone();
            // Working on cloned copy
            basicCar.onRoadPrice = basicCar.basePrice + BasicCar.SetAdditionalPrice();
            Console.WriteLine($"Car is: {basicCar.modelName}, and it's price is Rs. { basicCar.onRoadPrice }");

            //ford
            basicCar = ford.Clone();
            // Working on cloned copy
            basicCar.onRoadPrice = basicCar.basePrice + BasicCar.SetAdditionalPrice();
            Console.WriteLine($"Car is: {basicCar.modelName}, and it's price is Rs. {basicCar.onRoadPrice}");

            //Car Factory
            CarFactory carFactory = new CarFactory();

            //getNano
            BasicCar basicCarFactory = carFactory.getNano();
            //Working on Copy Clone
            basicCarFactory.onRoadPrice = basicCar.basePrice + BasicCar.SetAdditionalPrice();
            Console.WriteLine($"Car is: {basicCar.modelName}, and it's price is Rs. { basicCar.onRoadPrice }");


            //RainGenics
            SoftwareAgrement agrement = new SoftwareAgrement("ABC Consultancy", new NonDisclosureAgreement { Id = 123, NDAgreementName="Source Code" }) ;
            agrement.Print();

            var cloneAgreement = agrement.ShallowCopy();
            cloneAgreement.Print("Initial Agreement");
            Console.ReadKey();

        }
    }
}

