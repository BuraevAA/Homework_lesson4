//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int Sumnum(int Num)
{
    int sum = 0;
    if(Num == 0) sum = 0;
    while(Num != 0)
    {
        sum = sum + (Num % 10);
        Num = Num/10;
    }
    return(sum);
}
Console.WriteLine(Sumnum(Num));
