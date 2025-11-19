
namespace Лр5;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        // Создаем меню один раз
        Menu menu = Menu_shenanigans.MenuBuild();

        // Выводим меню
        Console.WriteLine("=== Меню ===");
        menu.PrintMenu();
        Console.WriteLine("============\n");

        // Первый заказ
        Order order1 = new Order();
        order1.AddItem(menu.Items[0], 2);
        order1.AddItem(menu.Items[5], 1);

        Console.WriteLine("=== Замовлення 1 ===");
        order1.PrintOrder();
        Console.WriteLine();

        // Второй заказ

        Order order2 = new Order();
        order2.AddItem(menu.Items[1], 3);
        order2.AddItem(menu.Items[4], 2);
        Console.WriteLine("=== Замовлення 2 ===");
        order2.PrintOrder();
        Console.WriteLine();

        // Третий заказ
        Order order3 = new Order();
        order3.AddItem(menu.Items[2], 1);
        order3.AddItem(menu.Items[4], 2);
        order3.AddItem(menu.Items[5],1);

        Console.WriteLine("=== Замовлення 3 ===");
        order3.PrintOrder();
        Console.WriteLine();
    }
}

