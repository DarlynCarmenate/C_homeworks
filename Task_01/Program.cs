//  Напишите программу вычисления модуля числа

Console.WriteLine("Введите число: ");
string n = Console.ReadLine();
int number = int.Parse(n);

if (number < 0) number *= -1;

Console.WriteLine($"Модуль числа: {number}");

