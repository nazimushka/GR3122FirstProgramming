// # 19 Напишите программу, которая принимает на вход
// пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов
// * Для палиндрома любой длины

// 1)Read Data ()         1.P=ReadData("Введите полиндром тырыпыры...")
// 2) bool TestPolin(P)
// 3)Pint


// 2. bool TestPolin(intP)
//        12321
//        {
//        if (p/10000 == p%10)&& (p/1000*%10 == p/10 % 10)
//     return true;
//     elso
//     return false;
//        }

// 3.Print (TestPolin(P));


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

//Тест на Полиндром
bool TestPolin(int digit)
{
    if ((digit / 10000 == digit % 10) && ((digit / 1000) % 10 == (digit / 10) % 10))
    {
        return true;
    }
    else
    {
        return false;
    }
}

// Результат
void PrintResult(bool line)
{
    Console.WriteLine(line);
}

int digit = ReadData("Проверка на полиндром: ");
bool result = TestPolin(digit);
PrintResult(result);