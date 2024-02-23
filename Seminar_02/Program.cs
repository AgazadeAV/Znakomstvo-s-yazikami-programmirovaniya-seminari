// Семинарское занятие

// Первое задание
int num1 = 654;
int result = (num1 / 100) * 10 + (num1 % 10);
Console.WriteLine(result);
int first = num1 / 100;
int second = num1 % 10;
Console.Write("The num without second digit is " + first + second);

// Второе задание
int num2 = 483;
int firstDigit = num2 / 100;
int thirdDigit = num2 % 10;
int secondDigit = ((num2 - (first * 100)) - thirdDigit) / 10;
int result = 1;

for (int i = 1; i <= thirdDigit; i++)
{
    result *= secondDigit;
}
Console.WriteLine(result);

// Третье задание
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

// Четвёртое задание
int num3 = 541231;

if (num3 > 99)
{
    while (num3 >= 1000)
    {
        num3 /= 10;
    }
    Console.Write(num3 % 10);
}
else
{
    Console.Write("Третьей цифры нет");
}

// Домашнее задание

// Первое задание
int number = 161;
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Число " + number + " одновременно кратно 7 и 23");
}
else
{
    Console.WriteLine("Число " + number + " одновременно не кратно 7 и 23");
}

// Второе задание
double x = -5.51;
double y = 0;
if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвёртой четверти");
}
else if (x == 0 && y == 0)
{
    Console.WriteLine("Точка находится в центре координат");
}
else if (y == 0)
{
    Console.WriteLine("Точка находится на оси координат x");
}
else if (x == 0)
{
    Console.WriteLine("Точка находится на оси координат y");
}


// Третье задание
int number2 = 99;
int first = number2 / 10;
int second = number2 % 10;
int max = first;
if (second > first)
{
    max = second;
}
Console.WriteLine(max);

// Четвертое задание (1-ый вариант)
long number3 = 1512000541451000;
while (number3 >= 1)
{
    Console.Write((number3 % 10) + ",");
    number3 /= 10;
}

// Четвертое задание (2-ой вариант)
int n = 123456789;
int res = n;
int iter = 0.1;

while (res >= 1)
{
    res /= 10;
    iter *= 10;
}

while (iter > 1)
{
    n /= iter;
    iter /= 10;
    if (iter / 10 >= 1)
    {
        Console.Write(aRes % 10 + ", ");
    }
    else
    {
        Console.Write(aRes % 10 + ".");
    }
}
