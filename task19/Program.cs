/* 
Напишите программу, которая принмает на вход 2 числа 
и проверяет является ли одного число квадратом другого.
5, 25 - да
8, 9 - нет
*/
Console.WriteLine("Add number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add number 2");
int num2 = Convert.ToInt32(Console.ReadLine());
if ((num1 * num1 == num2) || (num2 * num2 == num1)) 
    Console.WriteLine("Yes");
else 
    Console.WriteLine("No");
