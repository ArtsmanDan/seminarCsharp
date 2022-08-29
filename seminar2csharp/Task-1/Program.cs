// Напишите программу , которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.



int Pack(int num)
{
    int higt, low, res;

    higt = num / 100;
    low = num % 10;
    res = higt * 10 + low;
    return res;

}
int randNum = new Random().Next(100,1000);

int res = Pack(randNum);

Console.WriteLine($"Из трехзначного числа {randNum} получается двузначное {res}");