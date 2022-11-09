﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeParttern
{
    public class Television : ElectronicGoods
    {
        public override void Details()
        {
            Price.DisplayDetails(ProductType);
        }
    }
}
