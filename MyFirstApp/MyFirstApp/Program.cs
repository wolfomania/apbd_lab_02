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

static int GetMax(int[] numbers)
{
    int max = 0;
    for (int i = 1; i < numbers.Length; i++)
    {
        max = numbers[max] < numbers[i] ? i : max;
    }

    return max;
}

int[] numbers = new[] { 1, 3, 5, 12, 65, 3, 5 };
double var = GetAverage(numbers);
Console.WriteLine(var);

Console.WriteLine(GetMax(numbers));