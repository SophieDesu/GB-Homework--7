//Задача 1: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

class Program
{
    static void Main()
    {
        Console.Write("Input M: ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Natural numbers in the range from {M} to {N}:");
        PrintNumbers(M, N);
    }

    static void PrintNumbers(int M, int N)
    {
        if (M > N)
        {
            return;
        }

        Console.Write(M + " ");
        PrintNumbers(M + 1, N);
    }
}
