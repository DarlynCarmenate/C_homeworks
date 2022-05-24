// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int DigitSum(int number)
{
    int result = 0;
    while(number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

Console.WriteLine(DigitSum(452));
Console.WriteLine(DigitSum(82));
Console.WriteLine(DigitSum(9012));