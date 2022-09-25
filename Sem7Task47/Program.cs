// # 47 Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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

// Ззаполнение двумерного массива
double[,] Fill2DArray(int row, int column, int downBorder, int topBorder)
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[row, column];

    for (int i = 0; i < row; i++) //строка
    {
        for (int j = 0; j < column; j++) //столбец
        {
            array2D[i, j] = Math.Round(rand.Next(downBorder, topBorder) * rand.NextDouble(), 2);
        }
    }
    return array2D;
}

// Печать двумерного массива
void Print2DArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} \t ");
        }
        Console.WriteLine();
    }
}

int column = 3;
int row = 4;
int downBorder = -10;
int topBorder = 10;

double[,] arr2D = Fill2DArray(row, column, downBorder, topBorder);
Print2DArray(arr2D);
