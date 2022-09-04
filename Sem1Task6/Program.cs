//======================================================
//# 6 Напишите программу, которая на вход принимает число
// выдает, явяляется, явялется ли число чётным
//======================================================

// string? inputLineA = Console.ReadLine();
// if (inputLineA != null)
// {
//     int inputNumberA = int.Parse(inputLineA);
//     bool outResult = (inputNumberA % 2 == 0);
//     if (Console.Write(outResult =  0));
//     {
//         Console.WriteLine("четное");
//     }
//     else
//     {
//         Console.WriteLine("нечетное");
//     }
// }

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber % 2 == 0)
        Console.WriteLine("Четное");
    else
    {
        Console.WriteLine("Нечетное");
    }
}
