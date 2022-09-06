//======================================================
//# 11 напишите программу, которая выводит случайное трехзначное
// число и удаляет вторую цифру этого числа
//======================================================

// intA=new random next (100; 1000)
//   768
//   B=A/100;
//   C=A&10
//
// A=B*10 + C
// Console.Writline (A)

void Evgen()
{
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);

    Console.WriteLine(number);

    int firstDigit = number / 100;
    int thirDigit = number % 10;

    Console.WriteLine(firstDigit * 10 + thirDigit);
}

void Konst()
{
    Console.WriteLine("Вариант1:");

    int number = new Random().Next(100, 1000);

    Console.WriteLine(number);

    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(charArray[0]);
    Console.WriteLine(charArray[2]);
}

void Mih()
{
    Console.WriteLine("Метод 1");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(100, 1000);

    Console.WriteLine(number);

    char[] charArray = number.ToString().ToCharArray();

    Console.WriteLine("" + charArray[0] + charArray[2]);
}

Konst();
