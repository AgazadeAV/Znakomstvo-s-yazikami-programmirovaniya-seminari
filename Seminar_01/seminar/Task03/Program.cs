// Сумма первой и последней цифры трёхзначного числа.

int num = 666;
int firstNum = num / 100;
int secondNum = num % 10;
int sum = firstNum + secondNum;
Console.WriteLine("Sum of first and last digit is " + sum);