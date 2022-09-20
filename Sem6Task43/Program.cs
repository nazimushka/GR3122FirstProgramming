// # 43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых

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

// Метод, который находит точку пересечения
int[] PointFind(int k1, int k2, int b1, int b2)
{
    int[] outarray = new int[2];
    int x = (b2 - b1) / (k1 - k2);
    int y = k1 * x + b1;
    outarray[0] = x;
    outarray[1] = y;

    return outarray;
}

int k1 = ReadData("Введите число k1: ");
int k2 = ReadData("Введите число k2: ");
int b1 = ReadData("Введите число b1: ");
int b2 = ReadData("Введите число b2: ");
int[] pointCoordin = PointFind(k1, k2, b1, b2);
PrintResult("Координаты точки пересечения 2-х прямых: " + (pointCoordin[0], pointCoordin[1]));
