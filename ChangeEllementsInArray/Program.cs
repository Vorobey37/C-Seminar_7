/*
Задайте двумерный массив.
//  Найдите элементы, у которых оба индекса чётные,
//   и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 2 3 4

// Новый массив будет выглядеть вот так:

// 1 4 7 2

// 5 **81** 2 **9**

// 8 4 2 4

// 1 **4** 3 **16**
*/
using System;
using static System.Console;
Clear();
int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}
int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2== 1)
            {
                array[i,j] = array[i,j]*array[i,j];
            }
        }
    }
    return array;
}

int[,] origin = GetArray(4, 4, -10, 10);
PrintArray(origin);
WriteLine();
int[,] change = ChangeArray(origin);
PrintArray(change);
