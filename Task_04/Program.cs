// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
string first = Console.ReadLine();
int a = int.Parse(first);

Console.WriteLine("Введите второе число: ");
string second = Console.ReadLine();
int b = int.Parse(second);

Console.WriteLine("Введите третье число: ");
string third = Console.ReadLine();
int c = int.Parse(third);

if (a < b) a = b;
if (a < c) a = c;
Console.WriteLine($"Наибольшее число {a}");