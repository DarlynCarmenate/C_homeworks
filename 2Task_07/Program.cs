// Напишите программу, которая на вход принимает трехзнаное число, а на выходе
// показывает вторую цифру этого числа

int Prompt(string message){
    Console.Write(message);
    string input = Console.ReadLine();
    int value = int.Parse(input);
    return value;
}

void SecondNum(int number)
{
    if (number < 99 || number > 999)
    {
        Console.WriteLine("Wrong digit");
    }
    else
    {
    Console.WriteLine($"The second number is: {number/10%10}");
    }
}

int num = Prompt("Please, enter triple digits: ");
SecondNum(num);