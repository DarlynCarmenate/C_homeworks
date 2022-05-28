// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] RandArray (int length)
{
	int[] answer = new int[length];
	for(int i = 0; i < length; i++)
	{
		answer[i] = new Random().Next(100, 1000);
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

int EvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

int[] arr = RandArray(12);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"There are {EvenNumber(arr)} even numbers in the array");
