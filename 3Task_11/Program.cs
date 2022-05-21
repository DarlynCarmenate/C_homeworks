// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.WriteLine(Polyndrom("Enter a number"));

string Polyndrom(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int len = number.Length;

    int i = 0;
    string answer = "Polyndrom";

    while (i < len / 2)
    {
        if (number[i] != number[len - i - 1])
        {
            answer = "Not polyndrom";
            break;
        }
        else if (number[i] == number[len - i - 1])
        {
            i++;
        }
    }
    return answer;
}

