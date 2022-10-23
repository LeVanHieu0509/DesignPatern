using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeParttern
{
    public class Ford : BasicCar
    {
        public Ford(string m)
        {
            this.modelName = m;
            basePrice = 500000;
        }
        public override BasicCar Clone()
        {
            return this.MemberwiseClone() as Ford;
        }
    }
}
