/*task01
Напишите программу, которая на вход принимает два числа
и на вход принимает два числа и проверяет, является ли первое число квадратом другого
a = 25; b = 5 -> yes
a = 2; b = 10 -> no
a = 9; b = -3 -> yes
a = -3; b = 9 -> no
*/
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2*number2)
Console.WriteLine("True");
else 
Console.WriteLine("False");