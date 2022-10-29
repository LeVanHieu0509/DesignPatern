using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class WholeWheat : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking the WholeWheat Bread (15 minutes)");

        }

        public override void MixIngredients()
        {
            Console.WriteLine("Gathering Ingredient for WholeWheat Bread.");
        }
    }
}
