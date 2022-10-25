/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого элемента в массиве нет */

Console.WriteLine("Введите строку: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите столбец: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = new Int32[7,7];

Random(array, -100, 100);
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

ElementValue(array, line, column);
void ElementValue(int[,] array, int line, int column)
{
if (line < 0 | line > array.GetLength(0) - 1 | column < 0 | column > array.GetLength(1) - 1)
            {
                Console.WriteLine("Элемент не существует");
            }
            else
            {
                Console.WriteLine("Значение элемента массива = {0}", array[line, column]);
            }
            Console.ReadLine();
}