// # 26 Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.
// Пример:
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// chararay - массив строr

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

// Результат (МЕТОД ПРИНТ)
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Вариант с длиной строки

int CalculateDigitsString(int num)
{
    string numString = num.ToString();
    return numString.Length;
}

// Вариант с логарифмом
int CalculateDigits(int num)
{
    return (int)(Math.Log10(num) + 1);
}

// Вариант Андрея
int CalculateDigitCount(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += 1;
        num = num / 10;
    }
    return num;
}

int number = ReadData("Введите число: ");
int numberOfDigits = CalculateDigits(number);
PrintResult("Количество цифр в числе: " + numberOfDigits);
DateTime d1 = DateTime.Now;
Console.WriteLine(DateTime.Now - d1);

numberOfDigits = CalculateDigitsString(number);
PrintResult("Количество цифр в числе: " + numberOfDigits);
DateTime d2 = DateTime.Now;
Console.WriteLine(DateTime.Now - d2);

numberOfDigits = CalculateDigits(number);
PrintResult("Количество цифр в числе: " + numberOfDigits);
DateTime d3 = DateTime.Now;
Console.WriteLine(DateTime.Now - d3);
