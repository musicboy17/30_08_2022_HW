// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int rows = 4;
int columns = 4;
// int m = 16;
int [,] GetArray(int m, int n)
{   for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= columns; j++)  
    
    {
    matrix[i,j] = Next[10, 10]; 
    }
}
Console.WriteLine();
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLenth(0); i++)
    {
        for (int j = 0; j < matrix.GetLenth(1); j++)
        {
            Console.WriteLine(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
GetArray(rows, columns);
PrintArray(matrix);