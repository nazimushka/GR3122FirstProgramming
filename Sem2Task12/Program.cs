//======================================================
//# 12 Напишите программу, которая будет принимать
//на вход два числа и выводить,
//является ли второе число кратным первому. Если второе
//число некратно первому, то программа выводит о статок от деления .
//======================================================

// 1.
// A = Console.Readline ();
// B = Console.Readline ();
// int.parse();

// 2.
// bool R = B%A= = 0

// true или false

// 3. if (R)
// Console.WriteLine("число B кратно А")
// else
// Console.WriteLine ("некратно" + B%A)


// void Evgen()
// {
//     string? InputLineA = Console.ReadLine();
//     string? InputLineB = Console.ReadLine();

//     if (InputLineA != null && inputNumberB != null)
//     {
//         int inputNumberA = (int)int.Parse(InputLineA);
//         int inputNumberB = (int)int.Parse(InputLineB);

//         Console.WriteLine( inputNumberB % inputNumberA == 0 ? "Является Кратным" : inputNumberB % inputNumberA);
//     }
// }

// void Konst()
// {
//     Console.Write("Введите первое число: ");
//     string? InputLineA = Console.ReadLine();
//     Console.Write("Введите второе число: ");
//     string? InputLineB = Console.ReadLine();

//     int inputNumberA = int.Parse(InputLineA);
//     int inputNumberB = int.Parse(InputLineB);

//     Console.WriteLine(
//         (inputNumberB % inputNumberA == 0)
//             ? ("Второе число кратно первому")
//             : ("Остаток от деления: " + inputNumberB % inputNumberA)
//     );
// }

int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;

readData();
CoculateData();
PrintData();

// Получаем два числа от пользователя
void readData()
{
    Console.Write("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();

    inputNumberA = int.Parse(inputLineA);
    inputNumberB = int.Parse(inputLineB);
}

// Определяем кратность чисел
void CoculateData()
{
    result = (inputNumberB % inputNumberA == 0);
}

// Выводим данные вычисления
void PrintData()
{
    if(result)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Остаток от деления: " + inputNumberB % inputNumberA);
    }
}