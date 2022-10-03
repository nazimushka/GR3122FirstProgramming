// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(int line)
{
    Console.WriteLine(line);
}

int RecMN(int M, int N)
{
    if (M >= N)
        return N;
    return M + RecMN(M + 1, N);
}

int M = ReadData("Введите число M: ");
int N = ReadData("Введите число N: ");

Console.Write("Cумма натуральных элементов в промежутке от M до N: ");
PrintResult(M < N ? RecMN(M, N) : RecMN(N, M));
