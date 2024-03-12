/*
Задача 2: Напишите программу вычисления функции
Аккермана с помощью рекурсии. Даны два
неотрицательных числа m и n. 

n = 3, m = 2 -> A(n,m) = 29
*/

int AckermanFunction(int n, int m)
{
    if (n < 0 || m < 0)
    {
        // Возвращаем -1 или другое значение, указывающее на ошибку
        Console.WriteLine("Ошибка! Функция Аккермана работает только для положительных чисел.");
        return -1;
    }

    while (n != 0)
    {
        if (m == 0)
        {
            m = 1;
        }
        else
        {
            m = AckermanFunction(n, m - 1);
        }

        n--;
    }

    return m + 1;
}

Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());

int result = AckermanFunction(n, m);
Console.WriteLine($"n={n}, m={m} -> A(n,m) = {result}");

