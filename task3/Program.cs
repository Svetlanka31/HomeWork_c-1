﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i<N){
 if ((i%2)==0){
    i = i +2;
 }
 Console.WriteLine(i);
}
