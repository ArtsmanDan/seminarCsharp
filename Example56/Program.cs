/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и 

выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int[,] nums = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };

PrintMatrix(nums);
System.Console.WriteLine("================");
System.Console.Write(minSumStrInMatrix(nums));
System.Console.WriteLine("-я строка");

int minSumStrInMatrix(int[,] array)
{
    int[] sumArrayIndex = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArrayIndex[i] += array[i, j];
        }
    }
    return MinValueArray(sumArrayIndex) + 1;
}

int MinValueArray(int[] array)
{
    int min = array[0];
    int position = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            position = i;
        }

    }
    return position;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}