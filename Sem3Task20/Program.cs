// # 20 Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// Например:
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

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

// Расстояние между двумя точками.
double CalcData(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}

// Соберем данные
int x1 = ReadData("Ввдем x1 ");
int y1 = ReadData("Ввдем y1 ");
int x2 = ReadData("Ввдем x2 ");
int y2 = ReadData("Ввдем y2 ");

// Выведем результат.
PrintResult(Math.Round(CalcData(x1, y1, x2, y2), 2).ToString());
