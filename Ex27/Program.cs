/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */


Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int S = 0;
while(N > 0)
{
    S += N % 10;
    N = (N - N % 10) / 10;
}
  Console.Write(S);