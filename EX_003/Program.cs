// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int i = 2;
int j = 2;
int k = 2;
int [,] matrixFirst = new int[i,j];
int [,] matrixSecond = new int[j,k];
int [,] array = new int[0,0];

void FillMatrixFirst(int [,] matrixFirst)
{
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFirst.GetLength(1); j++)
        {
              matrixFirst[i,j] = new Random().Next(1, 10);   
                    
                    }

    }
} 
void FillMatrixSecond(int [,] matrixSecond)
{
    for (int j = 0; j < matrixSecond.GetLength(0); j++)
    {
        for (int k = 0; k < matrixSecond.GetLength(1); k++)
        {
              matrixSecond[j,k] = new Random().Next(1, 10);   
                    
                    }

    } 

}

FillMatrixFirst(matrixFirst);
FillMatrixSecond(matrixSecond);


void printMatF(int[,] matrixFirst)
{
//for (rows = 0; rows < rowsLength; rows++)
{
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFirst.GetLength(1); j++)
        {
            Console.Write(matrixFirst[i,j] + "\t");

        }



    // for (columns = 0; columns  < columnsLength; columns++)
    // {
    //     for (deep = 0; deep < deepLength; deep++)
    //     {
    //         Console.Write($"{array[rows, columns, deep]} {"("} {rows}{","}{columns}{","}{deep} {")"}{"\t"}");
    //     }
        
    // }
    Console.WriteLine();
        }
    }
}

void printMatS(int[,] matrixSecond)
{
//for (rows = 0; rows < rowsLength; rows++)
{
    for (int j = 0; j < matrixSecond.GetLength(0); j++)
    {
        for (int k = 0; k < matrixSecond.GetLength(1); k++)
        {
            Console.Write(matrixSecond[j,k] + "\t");

        }



    // for (columns = 0; columns  < columnsLength; columns++)
    // {
    //     for (deep = 0; deep < deepLength; deep++)
    //     {
    //         Console.Write($"{array[rows, columns, deep]} {"("} {rows}{","}{columns}{","}{deep} {")"}{"\t"}");
    //     }
        
    // }
    Console.WriteLine();
        }
    }
}


printMatF(matrixFirst);

Console.WriteLine();

printMatS(matrixSecond);
