// # 10 Напишите программу, которая принимает на вход
// трёхзначное число и на выходе
// показывает вторую цифру этого числа.

// # *10 Напишите программу, которая принимает на вход
// трёхзначное число и на выходе
// показывает вторую цифру этого числа. (получтить Любое
// число и превратить  его в целочисленное и длее
// определть 3 цифр этого)
// 12345 - 3
// 678 - 8


// 1. A=Console.Readline();
// 2. if (A length = = 3)
// {
// 3. [charr] Arr. = A To CharArray
//      [0][1][2]
// 4. Consol. WriteLine(Arr[1])
// }
// else
// {
// Consol.WriteLine ("Чило не3-х значное");
// }


void Gasanov()
{
    Console.WriteLine("Введите трехзначное число: ");

    string inputLine = Console.ReadLine() ?? "";

    if (inputLine.Length == 3)
    {
        char[] charArray = inputLine.ToString().ToCharArray();
        Console.WriteLine(charArray[1]);
    }
    else
    {
        Console.WriteLine("Число не трехзначное");
    }
}

Gasanov();
