// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

int Prompt(string message)
{
    Console.WriteLine(message);
    string first = Console.ReadLine();
    int number = int.Parse(first);
    return number;
}

void ShowThird(int a)
{
    if (a < 100)
    {
        Console.WriteLine("There's no third digit");
    }
    else
    {
        while (a > 999)
        {
            a = a / 10;
        }
        int result = a % 10;
        Console.WriteLine($"The third digit is: {result}");
    }
}

ShowThird(Prompt("Enter a number: "));