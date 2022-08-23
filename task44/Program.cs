// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Fibonacci (int number)
{
    if (number == 1) return Console.WriteLine("{1}");
    if (number == 2) return Console.WriteLine("{0, 1}");
   for (int i = 0; i < number; i++)
   {
     Console.WriteLine("number");
   }
}
