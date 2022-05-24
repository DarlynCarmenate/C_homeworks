// Напишите программу, которая задаёт массив из 8 элементов случайными числами 
// и выводит их на экран. Оформите заполнение массива и вывод в виде функции 

int[] RandArray (int length)
{
	int[] answer = new int[length];
	for(int i = 0; i < length; i++)
	{
		answer[i] = new Random().Next(1, 100);
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

int[] array = RandArray(8);
PrintArray(array);