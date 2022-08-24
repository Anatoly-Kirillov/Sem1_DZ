// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Напишите число: ");
double num1 = double.Parse(Console.ReadLine());
double N = 2;
while (N <= num1)
{
    Console.Write($"{N} ");
    N = N + 2;
}