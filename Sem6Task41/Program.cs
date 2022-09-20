// # 41 Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод, который выдаст кол-во чисел больше 0
int Count(int numOfDigits)
{
    int res = 0;
    for (int i = 0; i < numOfDigits; i++)
    {
        int number = ReadData("Введите число: ");
        if (number > 0)
            res++;
    }
    return res;
}

int numOfDigits = ReadData("Введите количество чисел: ");
int amount = Count(numOfDigits);

PrintResult("Сумма цифр больше 0: " + amount);
