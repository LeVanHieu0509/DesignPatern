using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeParttern
{
    //BasicCar là nguyên mẫu. Nó là một lớp trừu tượng có một phương thức trừu tượng
    //được gọi là Clone().
    public abstract class BasicCar
    {
        public int basePrice = 0, onRoadPrice = 0;
        public string modelName { get; set; }
        /*
         We'll add this price before
         the final calculation of onRoadPrice.
         */
        public static int SetAdditionalPrice()
        {
            Random random = new Random();
            int additionalPrice = random.Next(20000, 50000);
            return additionalPrice;
        }
        public abstract BasicCar Clone();
    }
}
