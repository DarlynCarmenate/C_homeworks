// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    double value = double.Parse(strValue);
    return value;
}

void FindIntersection(double b1, double b2, double k1, double k2)
{
    if (k1 == k2 && b1 == b2)
        Console.WriteLine("Eternal intersection");

    else if (k1 == k2)
        Console.WriteLine("No intersection");

    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"The intersection poit is {x:0.00}, {y:0.00}");
    }
}
double b1 = Prompt("Enter b1: ");
double b2 = Prompt("Enter b2: ");
double k1 = Prompt("Enter k1: ");
double k2 = Prompt("Enter k2: ");
FindIntersection(b1, b2, k1, k2);