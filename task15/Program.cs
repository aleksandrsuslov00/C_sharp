int randomNumber = new Random().Next(10, 100);
Console.WriteLine($"Рандомное число - {randomNumber}");
int numberOne = randomNumber % 10;
int numberTwo = randomNumber / 10;
Console.Write($"У числа {randomNumber} большая цифра - ");

if (numberOne > numberTwo)
{
    Console.Write(numberOne);
}
else {Console.Write(numberTwo);}
