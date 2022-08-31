// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int rows = 2;
int columns = 2;
int deep = 2;
int rowsLength = rows;
int columnsLength = columns;
int deepLength = deep;
int i = 0;
int j = 0;
int k = 0;




int [,,] array = new int[rows, columns, deep];;


Found:

void FillArray(int [,,] array)
{

    for (i = 0; i < rows; i++)
    {
        for (j = 0; j < columns; j++)
        {
            for (k = 0; k < deep; k++)
            {
                array[i,j,k] = new Random().Next(10, 100);
                
            }
                
        }
    }
}
FillArray(array);

if (array[0,0,0] == array[0,0,1] || array[0,0,0] == array[0,1,0] || array[0,0,0] == array[0,1,1] 
|| array[0,0,0] == array[1,0,0] || array[0,0,0] == array[1,0,1] || array[0,0,0] == array[1,1,0]
|| array[0,0,0] == array[1,1,1] 
|| array[0,0,1] == array[0,1,0] || array[0,0,1] == array[0,1,1] 
|| array[0,0,1] == array[1,0,0] || array[0,0,1] == array[1,0,1] || array[0,0,1] == array[1,1,0]
|| array[0,0,1] == array[1,1,1] 
|| array[0,1,0] == array[0,1,1] || array[0,1,0] == array[1,0,0] || array[0,1,0] == array[1,0,1]
|| array[0,1,0] == array[1,1,0] || array[0,1,0] == array[1,1,1] 
|| array[0,1,1] == array[1,0,0] || array[0,1,1] == array[1,0,1] 
|| array[0,1,1] == array[1,1,0] || array[0,1,1] == array[1,1,1]
|| array[1,0,0] ==  array[1,0,1] || array[1,0,0] == array[1,1,0] 
|| array[1,0,0] == array[1,1,1] ||  array[1,0,1] == array[1,1,0] ||  array[1,0,1] == array[1,1,1]
||  array[1,1,0] == array[1,1,1]
)
{   Console.WriteLine();
    Console.WriteLine("Числа повторяются! Идём с начала!");
    Console.WriteLine();
goto Found;
}
// Можно конечно сделать переход - не распечатывая массив к вновь генерации
// Случайных чисел массива - если надо - я переделаю.



for (rows = 0; rows < rowsLength; rows++)
{
    for (columns = 0; columns  < columnsLength; columns++)
    {
        for (deep = 0; deep < deepLength; deep++)
        {
            Console.Write($"{array[rows, columns, deep]} {"("} {rows}{","}{columns}{","}{deep} {")"}{"\t"}");
        }
        
    }
    Console.WriteLine();
}

