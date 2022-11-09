using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeParttern
{
    //Giao diện IPrice là giao diện người triển khai của chúng tôi.
    //Nó duy trì hệ thống phân cấp thứ hai

    public interface IPrice
    {
        void DisplayDetails(string product);
    }
}
