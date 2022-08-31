string[,] table = new string[2, 5];

// String.Empty;
// table[0,0]     table[0,1]    table[0,2]    table[0,4]
// table[1,0]     table[1,1]    table[1,2]    table[1,4]

// table[1,2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colum = 0; colum < 5; colum++)
//     {
//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
// }

// int [,] pic = new int[, ];

// for (int i = 0; i < 3; i++)
// {
//  for (int j = 0; j < 4; j++)
//  {
//      Console.Write($"{matrix[i, j]} ");
//  }   
//  Console.WriteLine();
// }





// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             // Console.Write($"{image[i, j]} ");
//             if(image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }

// PrintImage(pic);

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10); // [1, 10)
//         }
//     }
// }
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);





// метод который принимает число, факториал которого нужно вычислить

// double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");     //1*2*3 = 6
//}




//Метод вычисления чисел Фибоначчи

// f(1) = 1
// f(2) = 2

// f(n) = f(n - 1) + f(n - 2)


double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"{i} = {Fibonacci(i)}");
}