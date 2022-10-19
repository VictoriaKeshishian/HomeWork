/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.WriteLine("Введите размер массива:  ");
int size = (int)Convert.ToDouble(Console.ReadLine());
double[] array = new double[size];

Random rand = new Random();
for (int i = 0; i < array.Length; i++)
array[i] = rand.Next(-100, 100) + rand.NextDouble();

printArray(array);
MinMax(array);

void MinMax(double[] array, double min = int.MaxValue, double max = int.MinValue, double a = 0)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) 
        {
            max = array[i];
        }
        else if(array[i] < min) 
        {
            min = array[i];
        }
    }
    a = max - min;
    Console.WriteLine($"Максимальный элемент массива: {Math.Round(max,3)}");
    Console.WriteLine($"Минимальный элемент массива: {Math.Round(min,3)}");
    Console.WriteLine($"Разница между max min: {Math.Round(a, 3)}");
}

void printArray(double[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(Math.Round(array[i],3) + " ");
}
Console.WriteLine();
}