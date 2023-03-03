// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] GetArray(int size) 
// Метод для заполнения массива случ. числами (например от -99 до 99)
// Размер массива задается с консоли
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}

Console.Write($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int GetSum (int[] array, int sum)
{ 
    for (int i = 1; i < size; i+= 2)
    {
        sum = sum + array[i];

    }
    return sum;
}

int[] resultArray = GetArray(size);
int sum = GetSum(resultArray, 0);

Console.WriteLine($"[{String.Join(",", resultArray)}]");
Console.WriteLine ($"Искомая сумма = {sum}");