// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Введите размер массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] RandomArray(int len)
{
    int[] arrays = new int[len];
    for (int i = 0; i < arrays.Length; i++)
    {
        arrays[i] = new Random().Next(0, 50);
    }
    return arrays;
}
int[] result = RandomArray(lenght);

void PrintArray(int[] result1)
{
    Console.Write($"[ ");
    for (int i = 0; i < result1.Length; i++)
    {
        Console.Write($"{result1[i]} ");
    }
    Console.Write($"]");
}

PrintArray(result);
