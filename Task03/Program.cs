/*
Задача 3: Задайте произвольный массив. Выведете
его элементы, начиная с конца. Использовать
рекурсию, не использовать циклы.

[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 
*/

void PrintArrayReversed(int[] array, int i)
{
    if (i >= 0)
    {
        Console.Write($"{array[i]} ");
        PrintArrayReversed(array, i - 1);
    }
}

int[] array = { 1, 2, 5, 0, 10, 34 };
Console.Write($"[{String.Join(", ", array)}] => ");
PrintArrayReversed(array, array.Length - 1);

