using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeParttern
{
    internal class Program
    {
        //client
        static void Main(string[] args)
        {
            Console.WriteLine("***Bridge Pattern Demo.***");
            ElectronicGoods eItem = new Television();
            eItem.ProductType = "Sony Television";

            IPrice price = new OnlinePrice(1000);
            eItem.Price = price;
            eItem.Details();

            price = new ShowroomPrice(2000);
            eItem.Price = price;
            eItem.Details();

            ElectronicGoods dItem = new DVD();
            dItem.ProductType = "Sony DVD";

            IPrice Dprice = new OnlinePrice(100);
            dItem.Price = Dprice;
            dItem.Details();

            Dprice = new ShowroomPrice(500);
            dItem.Price = Dprice;
            dItem.Details();

            Console.ReadKey();

        }
    }
}
