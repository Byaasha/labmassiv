Console.WriteLine("Привет дядя Дима!");
Console.WriteLine("Работа на оценку 3");

int[] array = { 1, 2, 3, 4, 5 };
int max = array.Max();
int min = array.Min();
int sum = array.Sum();
double avg = array.Average();
int product = 1;
for (int i = 0; i < array.Length; i++)
{
    product *= array[i];
}

Console.WriteLine($"Max: {max}");
Console.WriteLine($"Min: {min}");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Avg: {avg}");
Console.WriteLine($"Mul: {product}");
Console.ReadKey();
Console.WriteLine();
  