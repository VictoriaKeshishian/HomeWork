/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

Random(array, 100, 1000);
Even(array);
printArray(array);

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

void Even(int[]arr, int sumEv = 0, int sumOdd = 0)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            sumEv = sumEv + 1;
        }
        else if (array[i] % 2 != 0)
        {
            sumOdd = sumOdd + 1;
        }
        
    }
    Console.WriteLine($"Количество четных чисел: {sumEv}");
    Console.WriteLine($"Количество нечетных чисел: {sumOdd}");
}
