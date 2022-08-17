// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int NumCount (int number)
// {
// int sum = 0;
// for (int i = 1; number > 0; i++)
// {
//     number = number/10;
//     sum = i;
// }
// return sum;
// }
// int result = NumCount(num);
// Console.WriteLine($"Количество цифр в числе {num} = {result}");



int DigitofNums(int number)
{
    int count = 0;
    if (number == 0) return 1;
    while(number > 0)
    {
        count++;
        number = number / 10;
    }
    return count;
}
int result = DigitofNums(num);
Console.WriteLine($"Количество цифр в числе {num}: {result}");
