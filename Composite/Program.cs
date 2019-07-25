using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingredient ingredient1 = new Ingredient("Harina", 100, 200, "gramos");
            Ingredient ingredient2 = new Ingredient("Leche", 20, 1, "litro");
            Ingredient ingredient3 = new Ingredient("Harina", 20, 1, "kilo");

            CakeComposite cakeComposite = new CakeComposite("Pastel de leche");
            cakeComposite.Add(ingredient1);
            cakeComposite.Add(ingredient2);
            cakeComposite.Add(ingredient3);

            Console.WriteLine(cakeComposite.TotalCost);

            Ingredient ingredient4 = new Ingredient("Chocolate", 200, 1,"litro");
            CakeComposite cakeCompositeChocolat = new CakeComposite("Pastel compuesto");

            cakeCompositeChocolat.Add(ingredient4);
            cakeCompositeChocolat.Add(cakeComposite);

            Console.WriteLine(cakeCompositeChocolat.TotalCost);

            Console.ReadKey();
        }
    }
}
