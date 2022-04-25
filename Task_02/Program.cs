// Напишите программу, которая на вход принимает значение, а на выходе показывает обратное значение.

Console.WriteLine("Введите число: ");
string n = Console.ReadLine();
double number = double.Parse(n);

double result = (double) 1 / number;
Console.WriteLine(result);
