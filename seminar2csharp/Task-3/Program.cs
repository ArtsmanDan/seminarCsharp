// Напишите программу , которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

bool CheckNumber(int x, int a, int b)
{
    if ((x % a == 0) & (x % b) == 0)

        return true;
// else return false;
    return false;

    
}
Console.WriteLine(" Программа проверки кратности числа двум другим числам");

Console.WriteLine("Введите число для проверки : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите Первое условие кратности : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите Второе условие кратности : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
bool result = CheckNumber(x,a,b);


if ( result)
    Console.WriteLine($"Число {x} кратно числу {a}  и числу {b} ");

else

    Console.WriteLine($"Число {x} НЕ кратно числам {a}  и  {b} ");