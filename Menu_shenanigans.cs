using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лр5
{
    public class Menu_shenanigans
    {
        public static Menu MenuBuild()
        {
            Menu menu = new Menu();

            menu.Items.Add(new Drink("Brandy", 100, 50, null, 40, "Алкогольний напій"));
            menu.Items.Add(new Drink("Кола", 39, 500, null, null, "Безалкогольний напій"));
            menu.Items.Add(new Drink("Чай з журавлиною", 59, 1000, "Зелений чай, журавлина свіжа, лимон, мед, м'ята", null, "Безалкогольний напій"));
            menu.Items.Add(new MainDish { Name = "Пельмені", Price_for_portion = 90, Gram_for_portion = 330, Ingridients = "фарш телячий, тісто, зелена цибуля, яйце", Category = "гаряча основна страва",  Is_vegan = false });
            menu.Items.Add(new MainDish { Name = "Весняний салат", Price_for_portion = 80, Gram_for_portion = 300, Ingridients = "Огірок, помадор, цибуля, капуста качанна, сіль, перець, сонячникова олія", Category = "салат", Is_vegan = true });
            menu.Items.Add(new MainDish { Name = "Запечена картопля", Price_for_portion = 40, Gram_for_portion = 200, Ingridients = "Картопля, паприка, сіль, перець, сонячникова олія", Category = "гаряча основна страва", Is_vegan = true });
            return menu;
        }
    }
}
