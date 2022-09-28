// #58 Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив случайными числами
int[,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder)
{
    System.Random numSint = new System.Random();
    //Создаем массив
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = numSint.Next(downBorder, topBorder + 1);
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

// Произведение двух матриц
int[,] ProductOfMatrixs(int[,] arr1, int[,] arr2)
{
    int[,] productMatrix = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                productMatrix[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return productMatrix;
}

int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите коколичество столбцов: ");
int[,] firstMatrix = Fill2DArray(row, col, 0, 9);
Print2DArray(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = Fill2DArray(row, col, 0, 9);
Print2DArray(secondMatrix);
Console.WriteLine("Результат прозведения двух матрица: ");
Print2DArray(ProductOfMatrixs(firstMatrix, secondMatrix));
