/*
Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
*/
/*
var array = GenerateArray(12);
PrintArray(array);
ReplaceArray(array);
System.Console.WriteLine();
PrintArray(array);
*/
int a = 5;
Increment(ref a);
System.Console.WriteLine(a);
void Increment(ref int num)
{
    num++;
    System.Console.WriteLine(num);
}
// ref - ссылка

void ReplaceArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
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