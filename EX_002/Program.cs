// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка


int rows = 4;
int columns = 4;
//int summ = 0;
int summ01 = 0;
int summ02 = 0;
int summ03 = 0;
int summ04 = 0;
int i =0;
int j =0;
int[,] array = new int[rows, columns];

for (i = 0; i < rows; i++)
    {
        for (j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
  for (i = 0; i < rows; i++)
{
    for (j = 0; j < columns; j++)
    {
        summ01 = summ01 + array[i,j];
    }   
    // for (j = 0; j < columns; j++)
    // {
    // summ02 = summ02 + array[1,j];
    //     summ03 = summ03 + array[2,j];
    //     summ04 = summ04 + array[3,j];
    // 
    
       Console.Write($"{array[i, j]}  ");
}

          Console.WriteLine($"Сумма элементов строки равняется: {summ01}");
          Console.WriteLine($"Сумма элементов строки равняется: {summ02}");
          Console.WriteLine($"Сумма элементов строки равняется: {summ03}"); 
          Console.WriteLine($"Сумма элементов строки равняется: {summ04}");




       
   
   
 
    
    
