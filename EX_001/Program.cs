﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = 3;
int columns = 4;
int[,] arr = new int[rows, columns];
int[,] result = new int[rows, columns];
string body="";
int k = 0;
int[] m = new int[0];



void GetArray(int i, int j)
{for (i = 0; i < rows; i++)
    {
        for (j = 0; j < columns; j++)
        {
            arr[i,j] = new Random().Next(1, 10);

        }
    }
}

void PrintArray(int[,] array)
{for (int i = 0; i < rows; i++)
   {
    for (int j = 0; j< columns; j++)
    {
        Console.Write($"{arr[i, j]} ");
        
        }
        Console.WriteLine();
    } 
}

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}


void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

GetArray(rows, columns);        
PrintArray(arr);
Console.WriteLine();

OrderArrayLines(arr);
WriteArray(arr);

