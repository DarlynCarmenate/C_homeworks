// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

int digit = new Random().Next(0, 30);
Console.WriteLine($"Проверим число {digit}");

if (digit % 2 == 0) 
Console.WriteLine("Число четное");
else
Console.WriteLine("Число нечетное");