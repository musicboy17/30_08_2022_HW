// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
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
int[,] temporary = new int[0,0];
int[,] result = new int[rows, columns];
int maxPosition01 = 0;
int maxPosition02 = 0;
int maxPosition03 = 0;

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
        Console.Write($"{array[i, j]} ");
        
        }
        Console.WriteLine();
    } 
}

// void GetResult(int[,] arr)
//    { for (int i = 0; i < rows; i++)
//      {
             
//       for (int j = 0; j < columns; j++)
//       {
//       result[i,j] = arr[i,j];  
      
//       }
//      } 

//    }

void Replase(int[,] array)
{    
    for (int i = 0; i < 1; i++)
     {
       for (int j = 0; j < columns; j++)
       {
            maxPosition01 = array[i,j];
            for (int k = 1; k < 4; k++)
            {
                if(array[i,k] > array[0,2] && array[i,k] > array[0,3])   
            {  maxPosition01 = array[i,k];
               result[0,0] = array[i,k];
            }
            }
            Console.ReadLine();
            Console.WriteLine($"{maxPosition01}");
       }   
            //Console.WriteLine($"{maxPosition01}");
            //Console.ReadLine();
            //if(array[i,j] > maxPosition01 && array[i,j] > array[0,2] && array[i,j] > array[0,3])
            //Console.WriteLine($"{maxPosition01}");
            //result[i,j] = array[0,1];
            //Console.WriteLine($"{array[i,j]}");
       

           /* if(array[0,1] > maxPosition01 && array[i,j] > array[0,2] && array[i,j] > array[0,3])
            {
                maxPosition01 = array[i,j];
                result[0,0] = array[0,1];}
                //Console.WriteLine($"{maxPosition01}");
       }  
     }            
/*                if(array[0,2] > maxPosition01 && array[0,2] > array[0,3])
            {   maxPosition01 = array[0,2];
                result[0,0] = array[0,2];

                //result[0,1] = array[0,1];

            }
            if(array[0,3] > maxPosition01)
            {
                maxPosition01 = array[0,3];
                result[0,0] = array[0,3];
          
            }   

            


                maxPosition02 = array[1,0]; 
            result[1,0] = array[1,0];
            //if(array[1,1] > maxPosition02)
            if(array[1,1] > maxPosition01 && array[1,1] > array[1,2] && array[1,1] > array[1,3])
            
            {
                maxPosition02 = array[1,1];
                result[1,0] = array[1,1];
          
            }   
                 if(array[1,2] > maxPosition02 && array[1,2] >= array[1,3])
            
            {
                maxPosition02 = array[1,2];
                result[1,0] = array[1,2];
          
            }   
                if(array[1,3] > maxPosition02 && array[1,3] > array[1,2])
            
            {
                maxPosition02 = array[1,3];
                result[1,0] = array[1,3];
          
            }   
                maxPosition03 = array[2,0]; 
            result[2,0] = array[2,0];
            
            if(array[2,1] > maxPosition03 && array[2,1] > array[2,2] && array[2,1] > array[2,3] )
            {
                maxPosition03 = array[2,1];
                result[2,0] = array[2,1];
          
            }   
                if(array[2,2] > maxPosition03 && array[2,2] > array[2,3])
            {
                maxPosition03 = array[2,2];
                result[2,0] = array[2,2];
          
            }   
                if(array[2,3] > maxPosition03)
            {
                maxPosition03 = array[2,3];
                result[2,0] = array[2,3];
          
            }   
            }
       }
           
            Console.WriteLine(maxPosition01);
            Console.WriteLine(maxPosition02);
            Console.WriteLine(maxPosition03);   */

     
     }
}

GetArray(rows, columns);        
PrintArray(arr);
//GetResult(arr);
Replase(arr);
PrintArray(result);


