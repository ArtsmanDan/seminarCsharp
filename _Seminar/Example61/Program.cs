/*Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
int[] array1 = new int[] { 1, 3, 5, 7, 9 };
for(int i=0, g = array.Legth; i < j; i++, j--){
    temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}



*/

int[] num = new int[] {1, 4, 8, 2, 7, 6}; 
for (int i = 0; i < num.Length / 2; i++)
{
    int temp = num[i];
    num[i] = num[num.Length - i- 1];
    num[num.Length - i- 1] = temp;
}

for (int i = 0; i < num.Length; i++)
{
    //System.Console.Write($"-={num[i]}=- ");
    System.Console.Write("-=" + num[i] + "=- ");
}