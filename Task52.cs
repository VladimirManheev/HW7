﻿// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом 
//  столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine(ReleaseMatrix(matrix));

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-10, 10);
            Console.Write($"{matrix[i,j]} \t");
        }
            Console.WriteLine();
    }

}

void ReleaseMatrix(int[,] matrix);
 
{
    int summa=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        {
            
                summa+=matrix[i];
        }
    }
    return summa;
    Console.WriteLine($"{sum/i}");
}

    





