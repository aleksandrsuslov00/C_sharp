/*
Напишите программу, которая будет принимать на вход 
два числа и выводить, является ли второе 
число кратно первому. Если второе число не кратно первому, 
то программа выводит остаток деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/
Console.Write("Введите 1 число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int result = firstNumber % secondNumber;
if (result == 0) 
    Console.WriteLine($"кратно");
else
    Console.WriteLine($"остаток {result}");


