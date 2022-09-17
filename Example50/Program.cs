/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

int[,] nums = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

int row = 2;
int col = 1;

if (IsWithinArray(nums, row, col))
{
    System.Console.WriteLine($"{Search(nums, row, col)}");

}
else

    System.Console.WriteLine("Что такого элемента нет ? Да нет!!!");








bool IsWithinArray(int[,] matrix, int row, int col)
{
    return row < matrix.GetLength(0) & row >= 0
            & col < matrix.GetLength(1) & col >= 0;


}


int Search(int[,] nums, int i, int j)
{

    return nums[i, j];
}
