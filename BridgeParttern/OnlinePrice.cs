using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeParttern
{
    public class OnlinePrice : IPrice
    {
        int price;
        public OnlinePrice(int price)
        {
            this.price = price;
        }
        public void DisplayDetails(string product)
        {
            Console.Write($"\n{product} price at online is :{price}");
        }
    }
}
