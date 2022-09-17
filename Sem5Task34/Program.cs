// #34 Задайте массив заполненный случайными
// положительными трёхзначными числами.
// Напишите программу, которая покажет
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1

// Метод считывания данных пользователя
int ReadData(string line)
{
    Console.Write(line); // Выводим сообщение
    int arrayLength = int.Parse(Console.ReadLine() ?? "0"); // Считываем число
    return arrayLength; // Возвращаем значение
}

// Универсальный метод генерации и заполнения массива
int[] FillArray(int arrayLength)
{
    Random rnd = new Random(); //Генератор случайных чисел
    int[] array = new int[arrayLength]; //Создаем массив
    {
        //Заполняем массив
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(100, 999);
        }
    }
    return array; //Возвращаем результат
}

// Печать массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

//Метод подсчета количества четных и тест
int EvenCount(int[] RandomArray)
{
    int count = 0;
    for (int i = 0; i < RandomArray.Length; i++)
    {
        if (RandomArray[i] % 2 == 0)
            count++;
    }
    return count;
}

//Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int number = ReadData("Введите длину массива: ");
int[] RandomArray = FillArray(number);
PrintArray(RandomArray);
PrintResult($"Колличество четных чисел = {EvenCount(RandomArray)}");
