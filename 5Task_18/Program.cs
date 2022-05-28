// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] RandArray (int length)
{
	int[] answer = new int[length];
	for(int i = 0; i < length; i++)
	{
		answer[i] = new Random().Next(100, 500);
	}
	return answer;
}

void PrintArray(int[] arr)
{
	int count = arr.Length;
    Console.Write("[");
	for(int pos = 0; pos < count - 1; pos++)
	{
		Console.Write($"{arr[pos]}, ");
	}
    Console.Write($"{arr[arr.Length - 1]}]");
}

int OddIndex(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        count += array[i];
    }
    return count;
}

int[] arr = RandArray(10);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"The sum of odd index numbers is {OddIndex(arr)}");

