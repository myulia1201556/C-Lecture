// Упорядочивание данных
// внутри массива.
// Было: 6 8 3 2 1 4 5 7
// Стало: 1 8 3 2 6 4 5 7

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[ ");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");

    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
       int minPosition = i;

       for (int j = i + 1; j < array.Length; j++)
       {
        if(array[j] < array[minPosition]) minPosition = j;
       }

       int temporary = array[i];
       array[i] = array[minPosition];
       array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);