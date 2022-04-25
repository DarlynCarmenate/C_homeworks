// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
int N = int.Parse(a);

int i = 0;
while (i < N)
{
i += 2;
Console.Write($"{i} ");
}