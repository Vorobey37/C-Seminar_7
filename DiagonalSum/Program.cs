/*
 Задайте двумерный массив. 
// Найдите сумму элементов, находящихся
//  на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
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
int DiagonalSum(int [,]array)
{
    int lenght = array.GetLength(0)>array.GetLength(1) ? array.GetLength(1) : array.GetLength(0);
    int sum = 0;
    for (int i = 0; i<lenght; i++)
    {
        sum = sum + array[i, i];
    }
    return sum;
}
int [,]array = GetArray(4, 5, -5, 5);
PrintArray(array);
WriteLine();
WriteLine(DiagonalSum(array));
