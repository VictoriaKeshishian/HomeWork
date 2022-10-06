/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.WriteLine("Введите положительное число, ");
int n = Convert.ToInt32(Console.ReadLine());
int amount = n.ToString().Length;

if(amount < 3 || n < 0)
{
    Console.WriteLine("Третьей цифры нет, или вы ввели отрицательное число");
}
else
{
    Console.WriteLine(n.ToString()[2]);
}