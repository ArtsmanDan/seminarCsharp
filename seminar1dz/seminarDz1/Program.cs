﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write( "Please input integer first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "Plese input integer second number: ");

int max = 0;

int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 > num2)
    {
        max = num1;
    }
    
    else
    
    {
          max = num2;

    }   

Console.WriteLine($"Max namber is: {max} ");
*/


//  Задача 3 : Напишите программу , которая берет на входe три числа и выдает максимальное из этих чисел.
/*

Console.Write( "Please input integer first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( "Plese input integer second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( "Plese input integer third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (num1 > max)
{
    max = num1;
};

if ( num2 > max )
{
    max = num2;
}

if (num3 > max )
{
   max = num3;
}

Console.WriteLine(max);
*/

// Задача 6:    Напишите программу, которая на вход принимает число и выдаёт, 
//                является ли число чётным (делится ли оно на два без остатка).
/*

Console.WriteLine( "Input integer namber: " );

int i = Convert.ToInt32(Console.ReadLine());

    if (  i % 2 == 0 ) 
    {
        Console.WriteLine( $" Это четное  число : {i} " );

    }
    else
    {
        Console.WriteLine($" Это Не четное   число : {i} "); 
    }


*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
// И наоборот от числа N до 1.

/*
Console.WriteLine( "Input integer namber: " );

int n = Convert.ToInt32(Console.ReadLine());



 while ( n > 1)
     
    {if (n % 2 == 0) 
                
    Console.WriteLine(n);

      
           
n = n - 1;    
    }
*/

Console.WriteLine( "Input integer namber: " );

int n = Convert.ToInt32(Console.ReadLine());

int chetnumb = 0;
    if (n == 1)
        Console.WriteLine("Слишком малое число");
    


    while ( chetnumb < n -1 )
{
         chetnumb = chetnumb + 2;     

        Console.WriteLine((chetnumb));

        
}  
    


