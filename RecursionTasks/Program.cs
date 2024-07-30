using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Задача 1:");
        PrintNumbers(1, 5);
        Console.WriteLine("\n");
        PrintNumbers(4, 8);

        Console.WriteLine("\nЗадача 2:");
        Console.WriteLine($"A(2, 3) = {Ackermann(2, 3)}");

        Console.WriteLine("\nЗадача 3:");
        int[] array = { 1, 2, 5, 0, 10, 34 };
        PrintArrayReverse(array, array.Length - 1);
    }

    // Задача 1: Вывод натуральных чисел от M до N
    static void PrintNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m);
            if (m < n)
                Console.Write(", ");
            PrintNumbers(m + 1, n);
        }
    }

    // Задача 2: Функция Аккермана
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    // Задача 3: Вывод элементов массива с конца
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + " ");
            PrintArrayReverse(arr, index - 1);
        }
    }
}