using System;

internal class Program
{
    static void Main()
    {
        // Выполняем сложение и умножение.
        int sum = 2 + 2;
        int product = 3 * 3;

        // Скобки задают порядок действий в сложном примере.
        int result = ((18 + 6) * (15 - 7) - 36) / 6 + 4 * 5;

        // Выводим каждый пример вместе с ответом.
        Console.WriteLine($"2 + 2 = {sum}");
        Console.WriteLine($"3 * 3 = {product}");
        Console.WriteLine($"((18 + 6) * (15 - 7) - 36) / 6 + 4 * 5 = {result}");
    }
}
