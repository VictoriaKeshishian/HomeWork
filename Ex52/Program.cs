/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.WriteLine("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = new Int32[line, column];

Random(array, 0, 100);
void Random(int [,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random(). Next(min, max);
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
        Console.Write(array[i, j]+ " ");
    }
Console.WriteLine();
}
}


for(int j = 0; j < array.GetLength(1); j++)
    {
       double sum = 0;
       for (int i = 0; i < array.GetLength(0); i++)
       {
            sum = (sum + array[i, j]);
       }
       sum = sum / line;
       Console.Write(Math.Round(sum, 1) + "; ");
    }
 Console.WriteLine();
 

