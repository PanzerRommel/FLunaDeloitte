using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa una cadena para comprimir:");
        string input = Console.ReadLine();
        string compressed = CompressString(input);

        Console.WriteLine("Cadena original: " + input);
        Console.WriteLine("Cadena comprimida: " + compressed);
    }

    static string CompressString(string input)
    {
        StringBuilder compressed = new StringBuilder();
        int count = 1;

        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - 1 && input[i] == input[i + 1])
            {
                count++;
            }
            else
            {
                compressed.Append(input[i]);
                compressed.Append(count);
                count = 1;
            }
        }

        // Comparar con la longitud original o igual a la original
        if (compressed.Length < input.Length)
        {
            return compressed.ToString();
        }

        return input;
    }
}
