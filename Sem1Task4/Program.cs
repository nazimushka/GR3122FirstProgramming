//======================================================
//# 4 Напишите программу, которая на вход принимает три числа и
// выдает максимальное из этих.

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();

if (inputLineA != null && inputLineB != null && inputLineC != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);

    if (inputNumberA > inputNumberB)
        if (inputNumberA > inputNumberC)
        {
            Console.WriteLine("max =");
            Console.WriteLine(inputNumberA);
        }
    if (inputNumberB > inputNumberA)
        if (inputNumberB > inputNumberC)
        {
            Console.WriteLine("max =");
            Console.WriteLine(inputNumberB);
        }
    if (inputNumberC > inputNumberA)
        if (inputNumberC > inputNumberB)
        {
            Console.WriteLine("max =");
            Console.WriteLine(inputNumberC);
        }
}
