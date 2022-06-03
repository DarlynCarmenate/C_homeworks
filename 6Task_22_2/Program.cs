// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
// ввёл пользователь.

int PosNum()
{
    string word;
    int count = 0;

    while (true)
    {
        Console.WriteLine("Enter a number: ");
        word = Console.ReadLine();
        if (word == "") return count;
        else if (int.Parse(word) > 0) count++;
    }
}

Console.WriteLine(PosNum());