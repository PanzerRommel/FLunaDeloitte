using System;

class Program
{
    static void Main()
    {
        // Llama a la función FizzBuzz para imprimir los números del 1 al 200
        FizzBuzz(1, 200);
    }

    static void FizzBuzz(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
