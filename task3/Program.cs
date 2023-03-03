// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Используйте NextDouble(). можно округлить до целого


Console.Write($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] GetArray(int size) 
// Метод для заполнения массива случ. вещ. числами 
// Размер массива задается с консоли
{
    double [] array = new double [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble(), 2); 
    }
    return array;
}

double DifMaxMin (double[] array)
{
    double diff = 0;
    double max = array.Max();
    double min = array.Min();
    diff = max - min;
return diff;
}

double[] resultArray = GetArray(size);
double diff = DifMaxMin (resultArray);

Console.WriteLine($"[{String.Join(",", resultArray)}]");

Console.WriteLine ($"Разница между максимальным и минимальным элементом массива = {Math.Round(diff,2)}");