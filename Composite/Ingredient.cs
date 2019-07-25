using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// leaf.
    /// </summary>
    class Ingredient : Component
    {
        public int Quantity { get; set; }

        public string Unit { get; set; }

        public Ingredient(string name, decimal cost, int quantity, string unit) : base(name, cost)
        {
            this.Quantity = Quantity;
            this.Unit = Unit;
        }
    }
}
