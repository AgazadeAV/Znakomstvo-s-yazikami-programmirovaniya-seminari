// Напишите программу, которая принимает на вход трёхзначное целое 
// число и на выходе показывает сумму первой и последней цифры этого числа.

int num = 666;
int firstNum = num / 100;
int secondNum = num % 10;
int sum = firstNum + secondNum;
Console.WriteLine("Sum of first and last digit is " + sum);