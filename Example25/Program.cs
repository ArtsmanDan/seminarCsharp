/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/

Console.WriteLine("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
int i = 1;
int count = a;
while (i<b)
{
    count =   count * a;
    i++;


}
    Console.WriteLine($"A в степени B равно: {count}" );