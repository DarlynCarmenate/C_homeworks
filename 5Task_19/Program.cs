// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.

double[] RandArray (int length)
{
	double[] answer = new double[length];
	for(int i = 0; i < length; i++)
	{
		answer[i] = new Random().NextDouble() * 100;
	}
	return answer;
}

void PrintArray(double[] arr)
{
	int count = arr.Length;
    Console.Write("[");
	for(int pos = 0; pos < count - 1; pos++)
	{
		Console.Write($"{arr[pos]:0.0}, ");
	}
    Console.Write($"{arr[arr.Length - 1]:0.0}]");
}

double MinMax(double[] array)
{
    int i = 0;
    double min = array[i];
    double max = array[i];
    for (i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        min = array[i];

        if(array[i] > max)
        max = array[i];
    }
    Console.WriteLine($"Minimum number: {min:0.0}");
	Console.WriteLine($"Maximum number: {max:0.0}");
	double result = max - min;
	return result;
}

double[] arr = RandArray(10);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"The difference of max and min numbers: {MinMax(arr):0.0}");


