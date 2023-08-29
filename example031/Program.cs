/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

using System.Data;
using System.Xml.XPath;
var array = GenerateArray(12);
PrintArray(array);
var resultMoreZero = SumElementsMoreZero(array);
var resultLessZero = SumElementsLessZero(array);
System.Console.WriteLine($"Сумма положительных элементов = {resultMoreZero}, сумма отрицательных элементов {resultLessZero}");

int SumElementsMoreZero (int[] array)
{
    int result = default;

    foreach (var item in array)
    {
        if (item > 0)
        {
            result += item;
        }
    }
    return result;
}

int SumElementsLessZero (int[] array)
{
    int result = default;

    foreach (var item in array)
    {
        if (item < 0)
        {
            result += item;
        }
    }
    return result;
}

int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-9, 10);
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

