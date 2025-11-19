using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лр5
{
    public class OrderItem
    {
        public IMenuItem Item { get; set; }
        public int Quantity { get; set; }

        public decimal TotalPrice => Item.Price_for_portion * Quantity;

        public override string ToString()
        {
            return $"{Item.Name} x {Quantity} = {TotalPrice} грн";
        }
    }
}
