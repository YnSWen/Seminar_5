// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и 
// предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Write($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] GetArray(int size)
// Метод для заполнения массива случ. целыми числами (например от 0 до 9) 
// Размер массива задается с консоли
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int[] array = GetArray(size);

int[] Multiplication(int[] array, int size)
{
    // size2 - размер для второго массива с результатами
    int size2 = (size / 2) + (size % 2);
    int j = size - 1;
    int[] array2 = new int[size2];
    int i = 0;

    while (i < size2)
    {
        if ((i != j) || (j - i != 1))
        {
        array2[i] = array[i] * array[j];
        j--;
        i++;
        }

        else if (i == j)
        {
            array2[i] = array[i]; 
        }
        
        else if (j - i == 1)
        {
        array2[i] = array[i] * array[j];
        }
    }
    return array2;
}


int[] resultarray = Multiplication(array, size);

Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Результаты произведения пар чисел: [{String.Join(", ", resultarray)}]");
