using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeParttern
{
    public class ShowroomPrice : IPrice
    {
        int price;
        public ShowroomPrice(int price)
        {
            this.price = price;
        }
        public void DisplayDetails(string product)
        {
            Console.Write($"\n{product} price at showroom is :{price}");
        }
    }
}
