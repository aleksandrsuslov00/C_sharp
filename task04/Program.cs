/*task04
Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа
*/
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int integer = 0;

if (number < 100 || number > 999) Console.WriteLine("Трехзначное число");
else {
    integer = number % 10;
    Console.WriteLine(integer);
}