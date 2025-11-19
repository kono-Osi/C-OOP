using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лр5
{
    public abstract class Food : IMenuItem
    {
        public string Name { get; set; }
        public decimal Price_for_portion { get; set; }
        public int Gram_for_portion { get; set; }
        public string Ingridients { get; set; }
        public string Category { get; set; }
        public bool Is_vegan { get; set; }
        public string VeganLabel => Is_vegan ? "Веганська" : "Не веганська";
    }
}
