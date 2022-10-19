/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

Random(array, 0, 100);
printArray(array);
SumOdd(array);


void Random(int[]arr, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
    {
        arr[i] = new Random(). Next(min, max);
    }
}

void printArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

void SumOdd(int[] array, int sum = 0, int count = 0)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 != 0)
        {
            count++;
            sum = sum + array[i];
        }
    }
    Console.WriteLine($"Количество нечетных элементов: {count}");
    Console.WriteLine($"Сумма нечетных элементов: {sum}");
}