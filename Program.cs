// string numbers = Console.ReadLine();

// string[] arrayNumbers = numbers.Split(" "); 

// int[] result = new int[arrayNumbers.Length];
// int count = 0; 
// for (int i = 0; i < arrayNumbers.Length; i++)
// {
// result[i] = Convert.ToInt32(arrayNumbers[i]);
// if (result[i] > 0)
// {
// count++; 
// }
// }
// Console.WriteLine($"Массив: [{String.Join("; ", result)}]");
// Console.WriteLine(count);

double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());

double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 -k2);
double y = k1 * (b2 - b1) / (k1 -k2) + b1;

Console.WriteLine($"Точка пересечения: ({x}, {y})");