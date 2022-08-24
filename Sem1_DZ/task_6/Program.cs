// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Напишите число: ");
double number1 = double.Parse(Console.ReadLine());
if(number1 % 2 == 0)
{
    Console.WriteLine($"Указанное число: {number1} - чётное");
}
else
{
    Console.WriteLine($"Указанное число: {number1} - не чётное");
}