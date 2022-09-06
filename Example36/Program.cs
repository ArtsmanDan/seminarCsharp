/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
 стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int length = 4;
int min = -999;
int max = 999;
int[] array = BildingArray( min,  max, length );
int x = OddNumber(array);
PrintArray(array);
System.Console.Write(" -> ");

System.Console.WriteLine(x);
int[] BildingArray(int min, int max, int length )
{
     Random rnd = new Random();

    int[] array = new int[length];

    for ( int i =0; i < array.Length; i++)
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


int OddNumber(int[]pot)
{
    int sumOddNumber = 0 ;
    for (int i = 0; i < pot.Length; i++)
    {
        if ( i % 2 !=0)  sumOddNumber = sumOddNumber + pot[i] ;
    }
    return sumOddNumber;
}