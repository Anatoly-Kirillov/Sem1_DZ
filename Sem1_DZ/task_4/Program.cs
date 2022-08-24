// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Напишите первое число: ");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число: ");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine("Напишите третье число: ");
double num3 = double.Parse(Console.ReadLine());

double max = num1;

if(num2 > max)
{
    max = num2;
}
if(num3 > max)
{
    max = num3;
}
Console.WriteLine($"Максимальное число: {max}");
