// #15 Напишите программу, которая принимает на вход цифру,
// обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 1. A=Console.Readline();
// 2. D=int.Parse (A);
// 3.if D = = 6 || D = = 7
// Console.WriteLine("выходной день")
// {
//     else
// }
// Console.WriteLine("будний")

// * второй вариант
// Dictionary
void Gasanov()
{
    Console.WriteLine("Введите цифру: ");

    string inputLine = Console.ReadLine() ?? "";

    int DayOfWeek = int.Parse(inputLine);

    if (DayOfWeek > 7 || DayOfWeek < 1)
    {
        Console.WriteLine("Превышен лимит дней! В неделе - только 7");
    }
    else
    {
        if (DayOfWeek == 6 || DayOfWeek == 7)
        {
            Console.WriteLine("Выходной день");
        }
        else
        {
            Console.WriteLine("Будний день");
        }
    }
}

Gasanov();
