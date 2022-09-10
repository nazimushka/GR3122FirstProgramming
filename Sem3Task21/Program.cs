// # 21 Напишите программу, которая принимает на вход координаты
// двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// * Сделать метод загрузки точек


// X (6,5,7); y(5,6,2)
// Line.SubString(0,2)
// Line.Split(",") = string[]
// line. Index of (",")
// line lost Of  (",")

// Обычное решение (ЕСТЬ В СЕМИНАРЕ)
// 1) ReadData
// 1. x1,y1,z1, x2,y2,z2 =ReadData()
// 2) Calculate
// 2. e=корень (x2-x1)2 + (y2-y1)2 + (z2-z1)2
// 2-это квадрат
// 3) PrintReasult
// 3.Print(e)


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

// Расстояние между двумя точками.
double Calculate(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}

// Результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Соберем данные
int x1 = ReadData("Введем x1 ");
int y1 = ReadData("Введем y1 ");
int x2 = ReadData("Введем x2 ");
int y2 = ReadData("Введем y2 ");
int z1 = ReadData("Введем z1 ");
int z2 = ReadData("Введем z2 ");

// Выведем результат.
PrintResult(Math.Round(Calculate(x1, y1, z1, x2, y2, z2), 2).ToString());
