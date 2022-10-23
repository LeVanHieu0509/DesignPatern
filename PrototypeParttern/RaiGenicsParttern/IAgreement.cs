using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeParttern.RaiGenicsParttern
{
    internal interface IAgreement
    {
        IAgreement ShallowCopy();
        void Print(string mesager);
    }
}
