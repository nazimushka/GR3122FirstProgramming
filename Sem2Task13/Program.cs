// # 13 Напишите программу, которая выводит третью
// цифру заданного числа или сообщает,
// что третьей цифры нет.

// 10-ю решаем без звездочки, а 13-ю со *

// 1. A=Console.Readline();
// 2. if (A length > = 3)
// {
// 3. [charr] Arr. = A To CharArray
//      [0][1][2]
// 4. Consol. WriteLine(Arr[2])
// }
// else
// {
// Consol.WriteLine ("Такого числа нет");
// }

void Gasanov()
{
    Console.WriteLine("Введите число: ");

    string inputLine = Console.ReadLine() ?? "";

    if (inputLine.Length >= 3)
    {
        char[] charArray = inputLine.ToString().ToCharArray();
        Console.WriteLine(charArray[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

Gasanov();
