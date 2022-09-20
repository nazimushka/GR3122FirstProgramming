﻿// # 38 Задайте массив вещественных чисел. Найдите разницу
// между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.


// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Заполняем массив
double[] GenArray(int arrLength, int maxValue)
{
    double[] array = new double[arrLength];
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = Math.Round((ren.NextDouble() * maxValue), 2);
    }
    return array;
}

// печатаем массив
void PrintArray(double[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

// разница между макс и мин
double MaxMin(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        if (arr[i] < min)
            min = arr[i];
    }
    return max - min;
}

double[] arr = GenArray(50, 100);

PrintArray(arr);
PrintResult("Разница между max и min = " + MaxMin(arr));
