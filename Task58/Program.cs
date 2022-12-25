﻿// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix = FillMatrix(4, 4);
PrintMatrix(matrix);
System.Console.WriteLine();
int[,] matrix2 = FillMatrix2(4, 4);
PrintMatrix(matrix2);
System.Console.WriteLine();
int[,] multiplyMatrix = MultiplyMatrix(matrix, matrix2);
PrintMatrix(multiplyMatrix);

int[,] MultiplyMatrix(int[,] matrix, int[,] matrix2)
{
    int[,] multiplyMatrix = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    
    for(int i = 0; i < multiplyMatrix.GetLength(0); i++)
        {
            for(int j = 0; j < multiplyMatrix.GetLength(1); j++)
            {
                multiplyMatrix[i, j] = 0;
                
                for(int k = 0; k < matrix.GetLength(1); k++)
                {
                    multiplyMatrix[i, j] += matrix[i, k] * matrix2[k, j];
                }
            }
        }
    return multiplyMatrix;
}


int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

int[,] FillMatrix2(int rows, int columns)
{
    int[,] matrix2 = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix2;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}