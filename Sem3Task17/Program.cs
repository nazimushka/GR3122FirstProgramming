// Задача №17 Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой  находится эта точка.
// Например:
// x=34; y=-30 -> 4
// x=2; y=4-> 1
// x=-34; y=-30 -> 3

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
int QuaterTest(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;

    return -1;
}

// Результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x = ReadData("Ведите координат x: ");
int y = ReadData("Ведите координат y: ");

int res = QuaterTest(x, y);

PrintResult("Точка находится в четверти №:" + res);
