/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите трехзначное положительное число, ");
int n = Convert.ToInt32(Console.ReadLine());
int SecondN = (n%100)/10;
int amount = n.ToString().Length;
if(amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(SecondN);
}
