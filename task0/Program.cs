// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
if (a > max) max = a;
if (b > max) max = b;
Console.WriteLine("max = ");
Console.WriteLine(max);

int min = a;
if (a < min) min = a;
if (b < min) min = b;
Console.WriteLine("min = ");
Console.WriteLine(min);
