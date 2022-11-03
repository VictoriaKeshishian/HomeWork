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


/* Sort(array);
void Sort(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                for (int l = 0; l < array.GetLength(0) - 1; l++)
               
Console.WriteLine();
printArray(array); */