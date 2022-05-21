// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

void Squares(int num)
{
    double[] arr = new double[num];
    int i = 0;
    while (i < num)
    {
    arr[i] = Math.Pow((i+1), 3);
    Console.Write($"{arr[i]}, ");    
    i++;
    }
    Console.WriteLine();
}

Squares(5);
Squares(7);
Squares(9);