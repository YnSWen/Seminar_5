// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве. 

// [345, 897, 568, 234] -> 2

int[] GetArray(int size) 
// Метод для заполнения массива случ. полож. числами
// Размер массива задается с консоли
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

Console.Write($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int GetEvenNumbers (int[] array, int count)
{
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}


int[] resultArray = GetArray(size);
int CountEvenNumbers = GetEvenNumbers(resultArray, 0);

Console.WriteLine($"[{String.Join(",", resultArray)}]");
Console.WriteLine ($"Количесто четных чисел в массиве: {CountEvenNumbers}");