// # 65 Задайте значения M и N. Напишите программу, которая найдёт
// все натуральные числа от M до N.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

string RecMN(int M, int N)
{
    if (M >= N)
        return N.ToString();
    return RecMN(M + 1, N) + " " + M;
}

int M = ReadData("Введите число M: ");
int N = ReadData("Введите число N: ");

Console.Write("Список натуральных чисел: ");
PrintResult(M < N ? RecMN(M, N) : RecMN(N, M));
