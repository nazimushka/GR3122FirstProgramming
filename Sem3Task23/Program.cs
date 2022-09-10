// # 23 Напишите программу, которая принимает на вход число
//  (N) и выдаёт таблицу кубов
// чисел от 1 до N.1
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом

// ЕСТЬ В СЕМИНАРЕ

// чтение данных из консоли
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return number;
}

// 1 2 3 4 5 6
//  4 9 16 25 36
string LineNumbers(int numberN, int pow)
{
    int i = 1;
    string OutLine = string.Empty;
    while (i < numberN)
    {
        OutLine = OutLine + Math.Pow(i, pow) + "\t";
        ++i;
    }
    OutLine = OutLine + Math.Pow(numberN, pow);
    return OutLine;
}

// Результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число N: ");

PrintResult(LineNumbers(num, 1));
PrintResult(LineNumbers(num, 2));
PrintResult(LineNumbers(num, 3));
