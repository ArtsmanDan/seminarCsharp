/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

*/
System.Console.WriteLine("Input integer number: ");
int number  = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{number} -> {sum(number)}");

int sum(int number)
{
    int result = 0;
    while(number > 0)
    {
        result = result + number % 10;

        number = number /10;
    }

    return result;
}