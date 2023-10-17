using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine($"Antes del intercambio: a = {a}, b = {b}");
        SwapWithoutTemp(ref a, ref b);
        Console.WriteLine($"Después del intercambio: a = {a}, b = {b}");
    }

    static void SwapWithoutTemp(ref int a, ref int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }
}
