using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeParttern
{
    public class Nano : BasicCar
    {
        public Nano(string m)
        {
            modelName = m;
            //Setting a base price Nano
            basePrice = 100000;
        }
        public override BasicCar Clone()
        {
            // Creating a shallow copy and returning it
            return this.MemberwiseClone() as Nano;
        }
    }
}
