/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

System.Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int length = number.Length;

if ((number[0] == number[length-1])&(number[1] == number[length-2]))
{
System.Console.WriteLine("Да");
} else
{
    System.Console.WriteLine("Нет");
}
/*
bool b = true;
for (int i = 0; i < length/2; i++)
{
    if(number[i] != number[length-1-i]) {
       b = false;
       break;
    }
        
}
if (b) System.Console.WriteLine($"{number} -> да");
else System.Console.WriteLine($"{number} -> нет");

*/