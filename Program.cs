using System;

class Program
{
    static void Main()
    {
        int n = GetNumber("Podaj liczbę wyrazów ciągu do wygenerowania: ");

        Console.WriteLine("Ciąg Fibonacciego:");
        PrintFibonacciSequence(n);

        Console.ReadKey();
    }

    static void PrintFibonacciSequence(int n)
    {
        int first = 0;
        int second = 1;

        Console.Write($"{first}, {second}");

        for (int i = 2; i < n; i++)
        {
            int next = first + second;
            Console.Write($", {next}");

            first = second;
            second = next;
        }

        Console.WriteLine();
    }

    static int GetNumber(string message)
    {
        Console.Write(message);
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number < 1)
        {
            Console.WriteLine("Błędne dane. Podaj liczbę większą od zera.");
            Console.Write(message);
        }

        return number;
    }
}
