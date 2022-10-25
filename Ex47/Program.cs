/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.WriteLine("Введите количество строк: ");
int line = (int)Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int column = (int)Convert.ToDouble(Console.ReadLine());

double[,] array = new double[line, column];

Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = rand.NextDouble()+rand.Next(-100,100);
    }
    
printArray(array);
void printArray(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(Math.Round(array[i, j],1) + " ");
    }
Console.WriteLine();
}
}

