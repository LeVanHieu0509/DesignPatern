using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeParttern
{
    //ElectronicGoods là lớp trừu tượng của chúng ta.
    //Nó được đặt trong hệ thống phân cấp 1.

    public abstract class ElectronicGoods
    {
        public IPrice Price { get; set; }
        public string ProductType { get; set; }
        public abstract void Details();
    }
}
