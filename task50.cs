// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.Write("Введите позицию строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
InputMatrix(matrix);
ReleaseMatrix(matrix);


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i,j]} \t");
        }
            Console.WriteLine();
    }

}

void ReleaseMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            
            if (m <= m+1 && n <= n+1)
                Console.Write($"Значение элемента равно {matrix[m-1,n-1]} ");
            else    
                Console.Write("Такого элемента нет в массиве");    
        }
    }
   
}