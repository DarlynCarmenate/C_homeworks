// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

void WeekDay()
{
    int day = new Random().Next(1, 8);
    Console.Write($"{day}: ");
    if (day == 6 || day == 7)
    {
        Console.WriteLine("It's a holiday");
    }
    else
    {
        Console.WriteLine("It's a workday");
    }
}

WeekDay();