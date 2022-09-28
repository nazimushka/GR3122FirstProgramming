// # 56 Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метода генерации и заполнения двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder)
{
    System.Random numSintezator = new System.Random();
    // Создаем массив
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = numSintezator.Next(downBorder, topBorder + 1);
        }
    }
    return array2D;
}

//Печатаем двумерный массив
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Нахождение строки с наименьшей суммой элементов и фиксация индекса этой строки
int FindMinRow(int[,] array)
{
    int outIndexRow = 1;
    int min = int.MaxValue;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (min > sum)
        {
            min = sum;
            outIndexRow = i;
        }
        sum = 0;
    }
    return outIndexRow;
}

int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(row, col, 0, 9);
Print2DArray(arr2D);
PrintResult(
    "Номер (0 - это 1-я строка) строки с наименьшей суммой элементов = " + FindMinRow(arr2D)
);

// Я для себя вывод строки указал, не "индекс", а "номер" на будущее,
// чтобы помнить возвращаясь к этой задаче.
