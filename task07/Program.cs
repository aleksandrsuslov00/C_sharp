/*task07
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 1)
Console.WriteLine("нет, нечётное");
else
Console.WriteLine("да, чётное");
