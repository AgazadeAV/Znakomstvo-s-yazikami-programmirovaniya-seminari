// Написать программа, которая выявляет делятся ли числа без остатка,
// а если делятся с остатком, то вывести остаток на экран.

int firstNum = 3;
int secondNum = 7;

if (firstNum % secondNum != 0)
{
    Console.Write("Нет, остаток от деления: " + firstNum % secondNum);
}
else
{
    Console.Write("Да");
}