// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int NumCount (int number);
{

int i = 0;
for (int i=1; num>0; i++);
{
    num = num/10;
}
return i;
}
Console.WriteLine("Количество цифр в числе {num} = {i} ");

