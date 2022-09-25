// # 50 Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод генерации и заполнения массива
int[,] Fill2DArray(int row, int column, int min, int max)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array2D[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array2D;
}

// Печать двумерного массива
void Print2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} \t ");
        }
        Console.WriteLine();
    }
}

//Поиск элемента координаты
int FindElement(int x, int y, int[,] array2D)
{
    if (x < array2D.GetLength(0) && y < array2D.GetLength(1))
    {
        return array2D[x, y]; // x = строка; y = столбец
    }
    else
    {
        return -1;
    }
}

// Печать результата
void PrintResult(int x, int y, int[,] array2D)
{
    if (x < array2D.GetLength(0) && y < array2D.GetLength(1))
    {
        Console.WriteLine($"В этих координатах лежит число: {array2D[y, x]}");
    }
    else
    {
        Console.WriteLine("Элемент с координатами отсутствует");
    }
}

int row = ReadData("Введите количество строк: m: ");
int column = ReadData("Введите количество столбцов: ");
Console.WriteLine();

int[,] array = Fill2DArray(row, column, 1, 99);
Print2DArray(array);
Console.WriteLine();
int x = ReadData("Введите координату строки m: ") - 1;
int y = ReadData("Введите координату столбца n: ") - 1;
int element = FindElement(y, x, array);
PrintResult(y, x, array);
