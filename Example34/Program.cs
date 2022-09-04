/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] BildingArray(int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    foreach (var item in array)
    {
        System.Console.Write(item + ", ");
    }
    int origRow = Console.CursorTop;
    int origCol = Console.CursorLeft;
    Console.SetCursorPosition(origCol - 2, origRow);
    System.Console.WriteLine("]");
}

bool IsEven(int x)
{
    bool s = true;
    if (x % 2 == 0) s = true;
    else s = false;

    return s;

}