// №29 Напишите программу, которая задаёт массив из
// 8 элементов и выводит их на экран.
// * Ввести с клавиатуры длину массива
// и диапазон значений элементов

// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

//генерирование массива
int[] GenArray(int num) //метод принимает на вход длинну массисва
// int[] - квадратные скобки, тк на вход принемает массив
{
    Random rnd = new Random();
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

// Печать результата
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.WriteLine(array[array.Length - 1]);
    // Console.Write("]");
}

int arrayLength = ReadData("Введите длину массива: ");
int[] array = GenArray(arrayLength);
PrintArray(array);
