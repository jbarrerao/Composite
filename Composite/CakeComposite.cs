using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// Composite Object.
    /// </summary>
    class CakeComposite : Component
    {
        private List<Component> ingredients = new List<Component>();

        public decimal TotalCost
        {
            get
            {
                decimal cost = 0;
                foreach (var component in ingredients)
                {
                    if (component.GetType().Name == "CakeComposite")
                    {
                        cost += ((CakeComposite)component).TotalCost;
                    }
                    else
                    {
                        cost += component.Cost;
                    }
                }

                return cost;
            }
        }
        public void Add(Component component)
        {
            ingredients.Add(component);
        }

        public void Remove(Component component)
        {
            ingredients.Remove(component);
        }

        public CakeComposite(string name, decimal cost = 0) : base(name, cost)
        {
        }
    }
}
