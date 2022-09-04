//======================================================
//# 5 Напишите программу, которая на вход принимает число (N)
// а на выходе показывает все целые четные числа в промежутке от 1 до N
//======================================================

string? inputLineA = Console.ReadLine();
int B = 1;
if (inputLineA != null)
{
    int inputNumberA = int.Parse(inputLineA);
    while (B < inputNumberA)
    {
        if (B % 2 == 0)
            Console.Write(B + ", ");
        B = B + 1;
    }
    if (inputNumberA % 2 == 0)
        Console.Write(inputNumberA);
}
