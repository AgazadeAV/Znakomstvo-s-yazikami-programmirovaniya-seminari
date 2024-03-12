// Найти максимальное из трёх чисел.

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