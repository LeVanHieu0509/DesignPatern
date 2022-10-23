using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeParttern
{
    class CarFactory
    {
        private readonly BasicCar nano, ford;
        public CarFactory()
        {
            nano = new Nano("Green Nano");
            ford = new Ford("Ford Yellow");
        }
        public BasicCar getNano()
        {
            return nano.Clone();

        }
        public BasicCar getFord()
        {
            return ford.Clone();
        }
    }
}
