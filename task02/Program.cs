/*task02
Напишите программу, которая будет выдавать 
название дня недели по заданному номеру.
3 -> Среда
5 -> пятница
*/

int userInput = Convert.ToInt32(Console.ReadLine());
if(userInput == 1)
Console.WriteLine("Monday");
if(userInput == 2)
Console.WriteLine("Tuesday");
if(userInput == 3)
Console.WriteLine("Wednesday");
if(userInput == 4)
Console.WriteLine("Thursday");
if(userInput == 5)
Console.WriteLine("Friday");
if(userInput == 6)
Console.WriteLine("Saturday");
if(userInput == 7)
Console.WriteLine("Sunday");