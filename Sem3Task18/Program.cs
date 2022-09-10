﻿// #18 Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y).


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

// считает четверти
string QuaterBorderAsk(int numQuater)
{
    if (numQuater == 1)
        return "x > 0 y > 0";
    if (numQuater == 2)
        return "x < 0 y > 0";
    if (numQuater == 3)
        return "x < 0 y < 0";
    if (numQuater == 4)
        return "x > 0 y < 0";

    return "";
}

// Результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Ведите номер четверти: ");

string res = QuaterBorderAsk(num);

PrintResult(res);
