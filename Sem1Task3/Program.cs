//======================================================
//# 3 Напишите программу, которая будет
// выдавать название дня недели по заданному номеру
//======================================================

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputDayOfWeek = int.Parse(inputLine);

    // string[] dayOfWeek = new string[7];
    // dayOfWeek[0] = "понедельник";
    // dayOfWeek[1] = "вторник";
    // dayOfWeek[2] = "среда";
    // dayOfWeek[3] = "четверг";
    // dayOfWeek[4] = "пятница";
    // dayOfWeek[5] = "суббота";
    // dayOfWeek[6] = "воскресенье";

    // if (inputDayOfWeek > 7 || inputDayOfWeek < 1)
    // {
    //     Console.WriteLine("Такого дня нет");
    // }
    // else
    // {
    //     Console.WriteLine(dayOfWeek[inputDayOfWeek - 1]);
    // }





    string outDayOfWeek = string.Empty; //""

    // switch (inputDayOfWeek)
    // {
    //     case 1:
    //         outDayOfWeek = "понедельник";
    //         break;
    //     case 2:
    //         outDayOfWeek = "вторник";
    //         break;
    //     case 3:
    //         outDayOfWeek = "среда";
    //         break;
    //     case 4:
    //         outDayOfWeek = "четверг";
    //         break;
    //     case 5:
    //         outDayOfWeek = "пятница";
    //         break;
    //     case 6:
    //         outDayOfWeek = "суббота";
    //         break;
    //     case 7:
    //         outDayOfWeek = "воскресенье";
    //         break;
    //     default:
    //         outDayOfWeek = "Такого дня нет";
    //         break;
    // }



    outDayOfWeek = System.Globalization.CultureInfo
        .GetCultureInfo("ru-RU")
        .DateTimeFormat.GetDayName(
            (DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputDayOfWeek)
        );
    Console.WriteLine(outDayOfWeek);
}
