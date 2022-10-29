﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sourdogh sourdogh = new Sourdogh();
            sourdogh.Make();

            TwelveGrain grain = new TwelveGrain();
            grain.Make();

            WholeWheat wheat = new WholeWheat();
            wheat.Make();
        }
    }
}
