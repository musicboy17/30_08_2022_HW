// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int rows = 4;
int columns = 4;

int rowsLength = rows;
int columnsLength = columns;
int k = 1;
//int j = 1;
int rowsMin =1;
int columnsMin = 1;
int columnsMax = columns;
int rowsMax = rows;

int [,] table = new int[rows, columns]; 

void FillArray(int [,] table)
{
    for (int i = 0; i < rowsMin; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            table[i,j] = (k);
            k++;
        }
    }   k--;
        
        for (int i = rowsMax-1; i < rowsMax; i++)
        {
        for (int j = 0; j < columnsLength; j++)
        {
            table[j,i] = (k);
            k++;
        }
        }

        for (int i = rowsMax-1; i < rowsMax; i++)
        {
            for (int j = columnsLength-2; j >= 0; j--)
            {
                table[i,j] = (k);
          
            k++;
        
            }
        }    
            
        for (int i = rowsMax-2; i > rowsMin; i--)
    {
        for (int j = 0; j < columnsMin; j++)
        {
            table[i,j] = (k);
            k++;
        }
    }



       
    for (int i = 1; i < rowsMin+1; i++)
    {
        for (int j = 0; j < columnsMax-1; j++)
        {
            table[i,j] = (k);
            k++;
        }
    }
        
        for (int i = rowsMax-2; i <= rowsMax-2; i++)
        {
            for (int j = columnsLength-2; j > 0; j--)
            {
               table[i,j] = (k);
               
            k++;
        
            }
        }
        
}        
        

FillArray(table);
for (rows = 0; rows < rowsLength; rows++)
{
    for (columns = 0; columns  < columnsLength; columns++)
    {
        Console.Write($"{table[rows, columns]} " + "\t");
        

    }
    Console.WriteLine();
}

