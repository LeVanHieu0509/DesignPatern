using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Như là một cái nhà máy, nếu cần động vật hoang dã thì chọn ở đây
    //Muốn chọn là pet thú cưng thì cũng chọn ở đây
    class FactoryProvider
    {
        public static IAnimalFactory GetAnimalFactory(string factoryType) {
            //Độ ưu tiên
            if (factoryType.Contains("Wild"))
            {
                return new WildAnimalFactory();
            }
            else if (factoryType.Contains("Pet"))
            {
                return new PetAnimalFactory();
            }
            else
            {
                throw new ArgumentException("Ban can dien wild or pet");
            }
        }
    }
}
