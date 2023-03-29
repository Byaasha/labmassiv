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


Console.WriteLine("Привет дядя Дима!"); 
Console.WriteLine("Работа на 5");
double[,] mass2 = new double[2, 3]; 
Console.WriteLine(1 + "кофицент первого уравнения");
mass2[0, 0] = Convert.ToInt32(Console.ReadLine()); Console.WriteLine(2 + "кофицент первого уравнения");
mass2[0, 1] = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("ответ первого уравнения");
mass2[0, 2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(1 + "кофицент второго уравнения"); mass2[1, 0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(2 + "кофицент второго уравнения"); mass2[1, 1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ответ второго уравнения"); mass2[1, 2] = Convert.ToInt32(Console.ReadLine());
double x1 = ((mass2[0, 2] * mass2[1, 1]) - (mass2[1, 2])) / ((mass2[0, 0] * mass2[1, 1]) - (mass2[0, 1] * mass2[1, 0])); 
double x2 = (mass2[0, 0] * mass2[1, 2]) - (mass2[0, 2] * mass2[1, 0]) / (mass2[0, 0] * mass2[1, 1] - mass2[0, 1] * mass2[1, 0]);
Console.WriteLine("x1=" + x1 + " x2=" + x2); 
Console.ReadKey();
