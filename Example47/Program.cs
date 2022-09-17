﻿/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

double[,] array;
int m = 3;
int n = 4;

array = CreateMatrix(m,n);

PrintMatrix(array);


double[,] CreateMatrix(int m, int n)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble();
        }
       
    }
    return array;

}

void PrintMatrix(double[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
           System.Console.Write(Math.Round(array[i, j], 2) + "; ");  
        }
        System.Console.WriteLine();
    } 
}