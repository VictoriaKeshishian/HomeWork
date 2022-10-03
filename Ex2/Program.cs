/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
int a,b;
Console.Write("Введите первое число, ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число, ");
b = Convert.ToInt32(Console.ReadLine());
int max = a;
    if(max > b)
    {
        Console.WriteLine("max = {0}", max);

        Console.WriteLine("min = {0}", b);
    }

    else
    {
        Console.WriteLine("max = {0}", b);

        Console.WriteLine("min = {0}", a); 
    }
