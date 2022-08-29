//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Input three-digit integer number: ");
int n =Convert.ToInt32 (Console.ReadLine());

n = n % 100;
n = n / 10;


Console.WriteLine(n);
