/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите число, ");
string n = Console.ReadLine();
string a = "";
for(int i = n.Length - 1; i >= 0; i--)
{
    a += n[i];
}
 if(n == a)
 {
    Console.WriteLine("Это палиндром");
 }
else
{
    Console.WriteLine("Данное число не является палиндромом");
}