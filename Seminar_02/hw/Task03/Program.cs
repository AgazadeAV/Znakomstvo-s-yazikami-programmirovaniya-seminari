// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int number = 99;
int first = number / 10;
int second = number % 10;
int max = first;

if (second > first)
{
    max = second;
}
Console.WriteLine(max);
