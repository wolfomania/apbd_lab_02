// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");


static double GetAverage(int[] numbers)
{
    double sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum / numbers.Length;
}


