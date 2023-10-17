using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa la primera palabra:");
        string str1 = Console.ReadLine();

        Console.WriteLine("Ingresa la segunda palabra:");
        string str2 = Console.ReadLine();

        if (AreAnagrams(str1, str2))
        {
            Console.WriteLine($"{str1} y {str2} son anagramas.");
        }
        else
        {
            Console.WriteLine($"{str1} y {str2} no son anagramas.");
        }
    }

    static bool AreAnagrams(string str1, string str2)
    {
        str1 = str1.Replace(" ", "").ToLower();
        str2 = str2.Replace(" ", "").ToLower();

        if (str1.Length != str2.Length)
        {
            return false;
        }

        Dictionary<char, int> charCount1 = new Dictionary<char, int>();
        Dictionary<char, int> charCount2 = new Dictionary<char, int>();

        foreach (char c in str1)
        {
            if (charCount1.ContainsKey(c))
            {
                charCount1[c]++;
            }
            else
            {
                charCount1[c] = 1;
            }
        }

        foreach (char c in str2)
        {
            if (charCount2.ContainsKey(c))
            {
                charCount2[c]++;
            }
            else
            {
                charCount2[c] = 1;
            }
        }

        foreach (var kvp in charCount1)
        {
            char key = kvp.Key;
            int count1 = kvp.Value;

            if (!charCount2.ContainsKey(key) || charCount2[key] != count1)
            {
                return false;
            }
        }

        return true;
    }
}
