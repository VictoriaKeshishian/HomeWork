/* Задача 54.1 : Задайте двумерный массив. Напишите программу, которая упорядочит 
элементы по убыванию (или возрастанию)*/


 Console.WriteLine("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = new Int32[line, column];

Random(array, 0, 100);
void Random(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
}

printArray(array);
void printArray(int[,] array)
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

Console.WriteLine();

Sort(array);
void Sort(int[,] array)
{
var matrix = array.Cast<int>().OrderByDescending(a => a).ToArray();
int c = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = matrix[c];
                Console.Write(array[i, j] + " ");
                c++;
            }
    }       Console.WriteLine();
}
/*Sort(array);
void Sort(int[,] array)
{
for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int l = 0; l < array.GetLength(1); k++) 
        {
            for (int i = 0; i < array.GetLength(0); i++) 
            {
               for (int j = 0; j < array.GetLength(1); j++) 
                {
                    
                }
                             
            }
        }
    }
}  */ 
Console.WriteLine();
printArray(array); 
 

/*
 var matrix = new int[9, 5];
            var rnd = new Random();
 
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(12, 45);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
 
            var arr = matrix.Cast<int>().OrderByDescending(a => a).ToArray();
 
            int c = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[j, k] = arr[c];
                    Console.Write(matrix[j, k] + " ");
                    c++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();

 */   
