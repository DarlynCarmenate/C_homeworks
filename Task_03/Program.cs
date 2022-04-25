// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
string first = Console.ReadLine();
int a = int.Parse(first);

Console.WriteLine("Введите второе число: ");
string second = Console.ReadLine();
int b = int.Parse(second);

if (a > b) Console.WriteLine($"{a} большее число, {b} меньшее");
else Console.WriteLine($"{b} большее число, {a} меньшее");