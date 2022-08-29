/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

System.Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"{number} -> ");
int i = 1; 
    while (i < number)
{
    System.Console.Write($"{i*i*i}, " );
    i++;
}
System.Console.Write($"{i*i*i}" );


      