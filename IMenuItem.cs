using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лр5
{
     public interface IMenuItem
    {
        string Name { get; set; }
        decimal Price_for_portion { get; set; }
        int Gram_for_portion { get; set; }
        string Ingridients { get; set; }
    }
}
