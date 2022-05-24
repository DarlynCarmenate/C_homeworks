// Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.

int DigitPow(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

Console.WriteLine(DigitPow(3, 5));
Console.WriteLine(DigitPow(2, 4));