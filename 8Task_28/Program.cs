// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

int[,] FillArray(int row, int column, int from, int to)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(from, to);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int LowestSum(int[,] matr)
{
    int[] arr = new int[matr.GetLength(0)];
    int k = 0;
    int lowest = arr[0];
    int lowestIndex = 0; 
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        arr[k] = sum;
        Console.Write($"{arr[k]} ");
        k++;
    }
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < lowest)
        {
        lowest = arr[i];
        lowestIndex = i;
        }
    }
    return lowestIndex + 1;
}

int[,] matrix = FillArray(5, 5, -10, 10);
PrintArray(matrix);
Console.WriteLine($"The sums of rows are: ");
Console.WriteLine($"The lowest sum is on row {LowestSum(matrix)}");