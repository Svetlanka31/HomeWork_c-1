// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (1 < count && count < N ) {
    Console.WriteLine((N % 2) == 0);
    count++;
}
