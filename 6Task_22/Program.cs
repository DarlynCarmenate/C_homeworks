// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
// ввёл пользователь.

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int value = int.Parse(strValue);
    return value;
}

int PosNumbers(int value)
{
    int count = 0;
    for (int i = 1; i <= value; i++)
    {
        int a = Prompt($"Enter number {i}: ");
        if (a > 0) count++;
    }
    return count;
}

int m = Prompt("How many numbers are you goint to enter? ");
Console.WriteLine($"You've entered {PosNumbers(m)} positive numbers");
