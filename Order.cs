using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лр5
{
    internal class Order
    {
        private List<OrderItem> items = new();

        public IReadOnlyList<OrderItem> Items => items;
        public DateTime CreatedAt { get; } = DateTime.Now;
        public string Status { get; private set; } = "Новий";

        public decimal TotalPrice => items.Sum(i => i.TotalPrice);

        public void AddItem(IMenuItem item, int quantity = 1)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than 0");

            // Если то же блюдо уже в заказе — увеличиваем количество
            var existing = items.FirstOrDefault(i => i.Item.Name == item.Name);
            if (existing != null)
            {
                existing.Quantity += quantity;
                return;
            }

            items.Add(new OrderItem
            {
                Item = item,
                Quantity = quantity
            });
        }

        public void RemoveItem(string itemName)
        {
            items.RemoveAll(i => i.Item.Name == itemName);
        }

        public void SetStatus(string status)
        {
            Status = status;
        }

        public void PrintOrder()
        {
            Console.WriteLine($"Замовлення від {CreatedAt}");
            Console.WriteLine("--------------------------------");

            foreach (var orderItem in items)
            {
                Console.WriteLine(orderItem);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Всього до сплати: {TotalPrice} грн");
            Console.WriteLine($"Статус: {Status}");
        }
    }
}
