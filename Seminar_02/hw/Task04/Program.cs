// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

// 1-ый вариант (c запятой в конце)
long number1 = 1512000541451000;

while (number1 >= 1)
{
    Console.Write((number1 % 10) + ",");
    number1 /= 10;
}

// 2-ой вариант (без запятой в конце)
int number2 = 123456789;
int temp = number2;
int iter = 1;

while (temp >= 1)
{
    temp /= 10;
    iter *= 10;
}

while (iter > 1)
{
    int digits = number2 / (iter / 10);
    iter /= 10;
    
    if (iter / 10 >= 1)
    {
        Console.Write(digits % 10 + ", ");
    }
    else
    {
        Console.Write(digits % 10 + ".");
    }
}