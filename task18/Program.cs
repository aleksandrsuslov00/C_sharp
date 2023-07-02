/*
Напишите программу, которая принмает на вход число
и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

Console.WriteLine("Введите число: ");
int numOne = Convert.ToInt32(Console.ReadLine());
if (numOne % 7 == 0 && numOne % 23 == 0)
    Console.WriteLine("Число кратно 7 и 23");
else 
    Console.Write("Некратно 7 и 23");


