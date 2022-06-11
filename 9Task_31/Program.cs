// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные 
// числа в промежутке от M до N с помощью рекурсии.

void OddNums(int m, int n)
{
    if (n < m) return;
    if(n % 2 == 1) n -= 1;
    OddNums(m, n - 2);
    Console.Write($"{n} ");
}

OddNums(1, 11);
Console.WriteLine();
OddNums(10, 20);