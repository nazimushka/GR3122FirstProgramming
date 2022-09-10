//Напишите программу, которая принимает
// на вход два числа и проверяет, является
// ли одно число квадратом другого.
// Например:
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


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

//Тест на квадрат
bool SqrTest(int ferstNum, int secondNum)
{
    if (ferstNum == secondNum * secondNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// Вывод данных
void PrintData(int ferstNum, int secondNum)
{
    if (SqrTest(ferstNum, secondNum))
    {
        Console.WriteLine("Число " + ferstNum + " квадрат числа " + secondNum);
    }
    else
    {
        Console.WriteLine("Число " + ferstNum + " не квадрат числа " + secondNum);
    }
}

int num1 = ReadData("Введите число 1: ");
int num2 = ReadData("Введите число 2: ");

PrintData(num1, num2);
PrintData(num2, num1);
