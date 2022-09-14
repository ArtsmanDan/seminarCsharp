
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] array = CreateIntArrayFromeConsole();
int count = PozitivNumber(array);
PrintArray(array);
System.Console.WriteLine(" -> " + count);



int[] CreateIntArrayFromeConsole()
{
    System.Console.WriteLine(" Введите колличество чисел для работы программы");
    int x = Convert.ToInt32(System.Console.ReadLine());
    int[] array = new int[x];

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine("Введите число для заполнения массива " + i);

        array[i] = Convert.ToInt32(Console.ReadLine());


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

int PozitivNumber(int[] number)
{
    int result = 0;

    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] > 0)
        {
            result = result + 1;
        }
    }
    return result;
}
