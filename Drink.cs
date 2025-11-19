using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лр5
{
    public class Drink : Drinks
    {

        public Drink(string name, decimal price, int gram, string ingridients, float? alcohol, string type)
        {
            Name = name;
            Price_for_portion = price;
            Gram_for_portion = gram;
            Ingridients = ingridients;
            Alcohol = alcohol;
            Type = type;
        }

    }
}
