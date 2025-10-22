using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое слово: ");
        string word1 = Console.ReadLine();

        Console.Write("Введите второе слово: ");
        string word2 = Console.ReadLine();

        string result = word1 + " " + word2;

        Console.WriteLine("Результат: " + result);
    }
}