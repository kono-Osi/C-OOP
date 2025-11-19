using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лр5
{
    public class Menu
    {
        private List<IMenuItem> items = new List<IMenuItem>();

        // Метод добавления элемента
        public List<IMenuItem> Items => items;
        public void AddItem(IMenuItem item)
        {
            items.Add(item);
        }

        // Метод печати меню
        public void PrintMenu()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} — {item.Price_for_portion} грн, {item.Gram_for_portion} г");

                if (item is Food food)
                    Console.WriteLine($"  {food.VeganLabel}");
            }
        }
    }
}
