// # 24 Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.
// Например:
// 7 -> 28
// 4 -> 10
// 8 -> 36

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

// Результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int VariantSumSimple(int numA) //Получит чмсло до которого нужно считать
{
    int sumOfNumbers = 0; // Создаст внутри себя пременную в которой будет накапливаться результат
    for (int i = 1; i <= numA; i++) // потом в цикле он будет суммировать
    {
        sumOfNumbers += i; // -//- смотри выше
    }
    return sumOfNumbers; // выдаст из метода
}

int VarianSumGause(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + numA) * numA) / 2;
    return sumOfNumbers;
}

int numberA = ReadData("Введите число: A: ");
DateTime d1 = DateTime.Now;
int res1 = VariantSumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = VarianSumGause(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до A равна (простой метод): " + res1);
PrintResult("Сумма чисел от 1 до A равна (метод Гауса): " + res2);
