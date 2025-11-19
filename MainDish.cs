using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лр5
{
    public class MainDish : Food
    {
        public string FoodName => Name;
        public decimal FoodPrice_for_portion => Price_for_portion;
        public int FoodGram_for_portion => Gram_for_portion;
        public string? FoodIngridients => Ingridients;
        public string FoodCategory => Category;
        public bool FoodIs_vegan => Is_vegan;
    }
}
