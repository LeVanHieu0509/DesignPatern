using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Sourdogh : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking the Sourdogh Bread (20 minutes)");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Gathering Ingredient for Sourdogh Bread.");
        }
    }
}
