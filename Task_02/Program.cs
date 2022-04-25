// Напишите программу, которая на вход принимает значение, а на выходе показывает обратное значение.

Console.WriteLine("Введите число: ");
string n = Console.ReadLine();
int number = int.Parse(n);

Console.WriteLine((double) 1 / number);
