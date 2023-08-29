/*
Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
*/

var array = GenerateArray(10);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine(GetCount(array));

int GetCount(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item >= 10 && item <= 99)
        {
            count++;
        }
    }
    return count;
}

int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 1001);
    }
    return result;
}

void PrintArray(int[] array)
{
    foreach (int i in array) // перебирает непосредственно значение элементов массива
    {
        Console.Write($"{i} ");
    }
}