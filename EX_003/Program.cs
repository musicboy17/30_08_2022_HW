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
int l = 0;
int m = 0;
int [,] mult = new int[l,m];
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

{
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFirst.GetLength(1); j++)
        {
            Console.Write(matrixFirst[i,j] + "\t");

        }



    Console.WriteLine();
        }
    }
}

void printMatS(int[,] matrixSecond)
{
{
    for (int j = 0; j < matrixSecond.GetLength(0); j++)
    {
        for (int k = 0; k < matrixSecond.GetLength(1); k++)
        {
            Console.Write(matrixSecond[j,k] + "\t");

        }

    Console.WriteLine();
        }
    }
}

void multiplication(int[,] mult)
{

int[,] mult01 = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];

for (i = 0; i < matrixFirst.GetLength(0); ++i)
{
                for (j = 0; j < matrixSecond.GetLength(0); ++j)
 {                   for (k = 0; k < matrixSecond.GetLength(1); ++k)
 {
                        mult[i, k] += matrixSecond[i, j] * matrixSecond[j, k];
 }
 }
} }

void Test1()
        {
            int[,] matrixFirst = { { 2, 4}, { 3, 2 } };
            int[,] matrixSecond = { { 3, 4}, {3, 3 } };
 
            int[,] m = multiplication(int [,];  mult);
 
            for (i = 0; i < matrixFirst.GetLength(0); ++i)
            {
                for (j = 0; j < matrixSecond.GetLength(1); ++j)
                {
                    Console.Write(mult[i, k] + " ");
                }
                Console.WriteLine();
            }
        }



printMatF(matrixFirst);

Console.WriteLine();

printMatS(matrixSecond);

multiplication(matrixFirst);
