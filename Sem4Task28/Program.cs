// # 28 Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
// Например:
// 4 -> 24
// 5 -> 120

// чтение данных из консоли (МЕТОД РИДАТА)
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return number;
}

// факториал
long CalculateFactorial(int num)
{
    long factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

// Результат (МЕТОД ПРИНТ)
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int number = ReadData("Введите число: ");
long factorial = CalculateFactorial(number);
PrintResult("Факториал равен: " + factorial);
