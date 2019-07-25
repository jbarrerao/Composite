using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// Simple Object
    /// </summary>
    abstract class Component
    {
        public string Name { get; set; }

        public decimal Cost { get; set; }

        public Component(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}
