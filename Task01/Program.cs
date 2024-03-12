/*
Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.

M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/

void GetNaturalNumbersInRange(int m, int n)
{
    if (m == n)
    {
        if (n >= 0)
            Console.Write($"{n}");
    }
    else
    {
        if (m < n)
        {
            GetNaturalNumbersInRange(m, n - 1);
            if (n >= 0)
                Console.Write($", {n}");
        }
        else if (m > n)
        {
            if (n >= 0)
                Console.Write($"{m}, ");
            GetNaturalNumbersInRange(m - 1, n);
        }
    }
}

Console.WriteLine("Введите натуральное число M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {m}; N = {n} -> \"");
GetNaturalNumbersInRange(m, n);
Console.WriteLine("\"");

