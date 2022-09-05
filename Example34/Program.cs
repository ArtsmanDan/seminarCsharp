/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
int min = 100;
int max = 999;
int length = 4;

int[] array = BildingArray(min, max, length);
PrintArray(array);
System.Console.Write(" -> ");
System.Console.WriteLine(CountEvenNumbers(array));


int[] BildingArray(int min, int max, int lengthArray)
{
    Random rnd = new Random();
    int[] array = new int[lengthArray];
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = rnd.Next(min, max + 1);
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
    System.Console.Write("]");
}

bool IsEven(int x)
{
    bool s = false;
    if (x % 2 == 0) s = true;

    return s;

}

int CountEvenNumbers(int[] array)
{
    int x = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (IsEven(array[i])) x++;
    }

    return x;
}