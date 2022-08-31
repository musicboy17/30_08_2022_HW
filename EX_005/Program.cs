// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int rows = 7;
int columns = 7;

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
       Console.WriteLine(k);

        for (int i = rowsMax-1; i < rowsMax; i++)
        {
            for (int j = columnsLength-2; j >= 0; j--)
            {
                table[i,j] = (k);
          
            k++;
        
            }
        }    
            
            Console.WriteLine(k);

            Console.WriteLine(rowsMax);

        for (int i = rowsMax-2; i < rowsMin; i++)
    {
        for (int j = 0; j < columnsMax-3; j++)
        {
            table[i,j] = (k);
            k++;
        }
    }





         //   table[2,0] = (k);
         //   k++;
    
        
        
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
        
        
        
        /*
            table[2,2] = (k);
            k++;
            table[2,1] = (k);
*/
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

