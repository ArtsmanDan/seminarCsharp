// Напишите программу , которая будет принимать на вход два числа и выводить, является ли второе число кратрым первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления.


void CheckNumbers(int a, int b )
{
    int res = b % a;

    if (res ==0)
    
        Console.WriteLine($"Второе число кратно первому");

    else

        Console.WriteLine($"Остаток деления второго числа на первое равен {res}");
 
}
 Console.WriteLine(" Программа проверки второго числа на кратность первому");

Console.WriteLine($"Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите второе число: ");

int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

CheckNumbers(a,b);