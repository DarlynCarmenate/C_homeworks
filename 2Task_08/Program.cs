// Напишите программу, которая выводит 
// случайное трёхзначное число и удаляет вторую цифру этого числа.

void MakeItTwo()
{
    int rnd = new Random().Next(100, 1000);
    Console.WriteLine($"{rnd} -> {rnd / 100}{rnd % 10}");
}
MakeItTwo();