// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0


// Метод считывания данных пользователя
int ReadData(string line)
{
    Console.Write(line); // Выводим сообщение
    int arrayLength = int.Parse(Console.ReadLine() ?? "0"); // Считываем число
    return arrayLength; // Возвращаем значение
}

// Универсальный метод генерации и заполнения массива
//только границы заполнения массива меняются*
int[] FillArray(int arrayLength)
{
    Random rnd = new Random(); //Генератор случайных чисел
    int[] array = new int[arrayLength]; //Создаем массив
    {
        //Заполняем массив
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(-100, 100);
        }
    }
    return array; //Возвращаем результат
}

// //Печать массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

//Метод подсчета суммы элементов на нечетных позициях
int EvenSumPosition(int[] RandomArray)
{
    int sum = 0;
    for (int i = 0; i < RandomArray.Length; i = i + 2)
    {
        sum = sum + RandomArray[i];
    }
    return sum;
}

// Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int number = ReadData("Введите длину массива: ");
int[] RandomArray = FillArray(number);
PrintArray(RandomArray);
PrintResult($"Сумма чисел стоящих на нечетных позициях = {EvenSumPosition(RandomArray)}");
