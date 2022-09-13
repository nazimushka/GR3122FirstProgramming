// # 25 Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /,
// * и возведение в степень

// Решение:
// 1) ReadData ()  какое число в какую степень возводить
// 2) Pow()
// 3) PrintData()

// long Pow (Int A, Int B)
// {
//     long res = 1;
//     for (int i=0; i<B; i++)
//     res = res * A;
// return res
// }

// *Можно еще через Math.Pow


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

// Возводим в степень
long Pow(int numberA, int numberB)
{
    long result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

// Результат (МЕТОД ПРИНТ)
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int numberA = ReadData("Введите число А: ");
int numberB = ReadData("Введите число B: ");
long result = Pow(numberA, numberB);
PrintResult($"{result}");
