// Семинарское занятие

// Первое задание
int first = 25;
int second = 5;
if (second * second == first)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

//Второе задание
int n = 4;

for (int i = -n; i <= n; i++)
{
    Console.WriteLine(i + " ");
}

// Третье задание
int num = 666;
int firstNum = num / 100;
int secondNum = num % 10;
int sum = firstNum + secondNum;
Console.WriteLine("Sum of first and last digit is " + sum);

// Домашнее задание

// Первое задание
int firstNumber = 8;
int secondNumber = 6;
if (firstNumber > secondNumber)
{
    Console.WriteLine("Первое число больше");
}
else if (firstNumber == secondNumber)
{
    Console.WriteLine("Числа равны");
}
else
{
    Console.WriteLine("Второе число больше");
}

// Второе задание
int a = 5;
int b = 6;
int c = 7;
if (a > b && a > c)
{
    Console.WriteLine("Максимальное число это " + a);
}
else if (b > a && b > c)
{
    Console.WriteLine("Максимальное число это " + b);
}
else
{
    Console.WriteLine("Максимальное число это " + c);
}

// Третье задание
int number = 7;
if (number % 2 == 0)
{
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Нечётное");
}

// Четвёртое задание
int evenNumbers = 23;
for (int i = 2; i <= evenNumbers; i = i + 2)
{
    Console.WriteLine(i + " ");
}
