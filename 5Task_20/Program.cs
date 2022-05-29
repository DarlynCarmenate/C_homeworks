// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

int[] RandArray (int length)
{
	int[] answer = new int[length];
	for(int i = 0; i < length; i++)
	{
		answer[i] = new Random().Next(0, 10);
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

int[] PairsPow(int[] array)
{
    
    int[] new_array;
    if(array.Length % 2 == 1)
    {
       new_array = new int[array.Length / 2 + 1];
        new_array[new_array.Length - 1] = array[array.Length / 2];
    }
    else
    {
        new_array = new int[array.Length / 2];
    }
    int j = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        new_array[j] = array[i] * array[array.Length - 1 - i];
        j++;
    }
    return new_array;
}

int[] arr = RandArray(9);
PrintArray(arr);
Console.WriteLine();
int[] n_arr = PairsPow(arr);
PrintArray(n_arr);
Console.WriteLine();

int[] arr_2 = RandArray(10);
PrintArray(arr_2);
Console.WriteLine();
int[] n2_arr = PairsPow(arr_2);
PrintArray(n2_arr);
