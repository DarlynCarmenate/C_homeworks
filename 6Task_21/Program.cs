// Напишите программу, которая будет создавать копию 
// двумерного массива с помощью поэлементного копирования.

int[,] FillArray(int row, int column)
{
	int[,] array = new int[row, column];
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(10, 100); 
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
int[,] CopyArray(int[,] arr)
{
    int[,] new_arr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			new_arr[i, j] = arr[i, j]; 
        }
    }
    return new_arr;
}

int[,] array = FillArray(5, 5);
PrintArray(array);
Console.WriteLine();
CopyArray(array);
PrintArray(array);

