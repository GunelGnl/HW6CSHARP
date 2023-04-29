//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

System.Console.WriteLine("Add qty of digits");
int count = int.Parse(Console.ReadLine());
int[] digits = new int[count];
for (int i = 0; i < count; i++)
{
Console.Write($"Add digit {i+1}: ");
digits[i] = int.Parse(Console.ReadLine());
}
int positiveCount = 0;

foreach (int digit in digits)
{
if (digit > 0)
{
positiveCount++;
}
}
System.Console.WriteLine($"qty digits, more 0: {positiveCount}");
Console.ReadKey();


//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Add b1:");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Add k1:");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Add b2:");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("Add k2:");
double k2 = double.Parse(Console.ReadLine());2

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Points: ({x}, {y})");
Console.ReadKey();