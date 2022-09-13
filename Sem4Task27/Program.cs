// # №27 Напишите программу, которая принимает на вход
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// *Сделать оценку времени алгоритма через
// вещественные числа и строки



// int SumDigit (int num) // берет число
// {
//     int Sum = 0 // объявляет переменную
// while(num > 0) // цикл
// {
//     sum += num%10 // остаток от деления на 10
//     num = num/10
// }
//     return Sum
// }



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

int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

// Результат (МЕТОД ПРИНТ)
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int number = ReadData("Введите число: ");
int numberOfDigits = SumDigit(number);
PrintResult("Количество цифр в числе: " + numberOfDigits);
