/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
int length = 5;
double[] array = BildingArray(length);
PrintArray(array);
System.Console.Write(" -> ");
System.Console.WriteLine(DifferenceMaxMin(array));

double[] BildingArray(int lengthArray)
{
    Random rnd = new Random();
    double[] array = new double[lengthArray];
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = rnd.NextDouble() * 100;
    }
    return array;
}

void PrintArray(double[] array)
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

double DifferenceMaxMin(double[] array)
{
    double diff = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(min > array[i]) min = array[i];
        if(max < array[i]) max = array[i];
    }
    return diff = max - min;
}

