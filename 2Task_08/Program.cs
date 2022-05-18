// Напишите программу, которая выводит 
// случайное трёхзначное число и удаляет вторую цифру этого числа.

void MakeItTwo(int three)
{
    Console.WriteLine($"{three / 100}{three % 10}");
}

int rnd = new Random().Next(100, 1000);
Console.Write($"{rnd} -> ");
MakeItTwo(rnd);