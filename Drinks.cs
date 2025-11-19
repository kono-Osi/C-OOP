using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Лр5
{
    public abstract class Drinks : IMenuItem
    {
        public string Name { get; set; }
        public decimal Price_for_portion { get; set; }
        public int Gram_for_portion { get; set; }
        public string? Ingridients { get; set; }
        public float? Alcohol { get; set; }
        public string Type { get; set; }
    }
}
