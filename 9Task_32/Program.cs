// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N с помощью рекурсии.

int NumSum(int m, int n)
{
    if (n < m) return 0;
    return NumSum(m, n - 1) + n;
}

Console.Write(NumSum(1, 5));
