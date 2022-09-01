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
int min = 0;
string minimum = "";
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
//  for (i = 0; i < rows; i++)
//{
    for (j = 0; j < columns; j++)
    {
        summ01 = summ01 + array[0,j];
    }
    for (j = 0; j < columns; j++)
    {
        summ02 = summ02 + array[1,j];
    }
    for (j = 0; j < columns; j++)
    {
        summ03 = summ03 + array[2,j];
    }
    for (j = 0; j < columns; j++)
    {
        summ04 = summ04 + array[3,j];
    }
min = summ01;
minimum = "01";
if (summ02 < min)
   {min = summ02;
   minimum = "02";}
if (summ03 < min)
   {min = summ03;
   minimum = "03";}
if (summ04 < min)
   {min = summ04;
   minimum = "04";}    
    
    //summ02 = summ02 + array[1,j];
    //summ03 = summ03 + array[2,j];
    //summ04 = summ04 + array[3,j];
    // 
  //  } 
      // Console.WriteLine($"{array[i, j]}");

for (i = 0; i < rows; i++)
{
    for (j = 0; j< columns; j++)
    {
        Console.Write($"{array[i, j]}");
        
        }
        Console.WriteLine();
    }    Console.WriteLine($"Сумма элементов 1-ой строки равняется: {summ01}");
   
Console.WriteLine($"Сумма элементов 2-ой строки равняется: {summ02}");
Console.WriteLine($"Сумма элементов 3-ей строки равняется: {summ03}");
Console.WriteLine($"Сумма элементов 4-ой строки равняется: {summ04}");
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой - {minimum}");



