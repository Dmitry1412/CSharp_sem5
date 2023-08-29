//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.




var array = GenerateArray(12);
PrintArray(array);
System.Console.WriteLine(Iscontian(array, 5));

bool Iscontian(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
    }   
    
    return false;
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