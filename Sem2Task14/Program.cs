//======================================================
//# 14 Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
//======================================================

// 1. A=Console.ReadLine()
// 2. R1 = (A%7 == 0);
//    R2 = (A%23 == 0);
// 3. if (R1&&R2)   Логическое "и" && И Логическое "или" ||
// Console.WriteLine ("число кратное 7 и 23")
// else
// Console.WriteLine ("число некратное 7 и 23")

//Вариант Евгения

// Console.Write("Введите число: ");
// string? inputLineA = Console.ReadLine();
// int inputNumberA = int.Parse(inputLineA);

// if (inputNumberA % 7 == 0 && inputNumberA % 23 == 0)
// {
//     Console.Write("Число кратно одновременно 7 и 23");
// }
// else
// {
//     Console.Write("Число не кратно одновременно 7 и 23");
// }


// Вариант Михаила

// int number, resultA, resultB;


// //запрашивает число у пользователя 
// //(принимает текст запроса и команду выхода)
// int RequestNumber(string text = "Enter number", string exitCmd = "q")
// {
//     while (true) // цикл выполняется до введения целого числа или q
//     {
//         Console.Write(text + ": ");
//         string? inputLine = Console.ReadLine();
//         // Игнорируем пробел
//         if (inputLine == null)
//         {
//             continue;
//         }
//         //Выходим из программы
//         if (inputLine.ToLower() == exitCmd)
//         {
//             Environment.Exit(0);
//         }
//         //Выводим полученное число
//         if (int.TryParse(inputLine, out int number))
//         {
//             return number;
//         }
//     }
// }

// // чтение данных из сонсоли
// void ReadData()
// {
//     number = RequestNumber("Enter number");
// }


// // Определяем кратность чисел
// void CalculateData()
// {
//     resultA = number % 7;
//     resultB = number % 23;
// }

// // Вывод данных
// void PrintData()
// {
//     if (resultA == 0 && resultB == 0)
//     {

//         Console.WriteLine("Число кртно 7 и 23");
//     }
//     else
//     {
//         Console.WriteLine("Число не кртно 7 и 23");
//     }
// }


// ReadData();
// CalculateData();
// PrintData();


//Вариант Анатолия
string? inputLineA = Console.ReadLine();
if (inputLineA != null) Console.Write(((int.Parse(inputLineA) % 7 == 0) && (int.Parse(inputLineA) % 23 == 0)) ? ("Кратно") : ("Не кратно"));
