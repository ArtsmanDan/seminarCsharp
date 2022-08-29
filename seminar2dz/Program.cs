
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("Input three-digit integer number: ");
int n =Convert.ToInt32 (Console.ReadLine());

n = n % 100;
n = n / 10;


Console.WriteLine(n);
*/
// Задача 13. Напишите программу, которая принимает на вход число, на выходе показывает третью цифру , 
//или сообщение если ее нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
/*
Console.WriteLine("Input integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
int nn = n;
int x = 1;

while(nn > 9){
    x++;
    nn = nn /10;
}

int[] array = new int[x];
int i = 0;
while(n > 9){
 
    array[i] = n % 10;
    n = n / 10;
    i++;
}

array[i] = n;

for (int j = 0; j < array.Length; j++)
{
    //Console.Write(array[j] + " ");
}

if(array.Length > 2){
    Console.WriteLine(array[array.Length - 3]);
}else Console.WriteLine("Его нет");

*/


Console.WriteLine("Input integer number: ");
string number = Console.ReadLine();

if (number.Length > 2)
{
    Console.WriteLine($"Третья цифра в этом выражении: {number[2]}");
}
else

 Console.WriteLine($"Третья цифры нет в этом слове");

 
 
 
