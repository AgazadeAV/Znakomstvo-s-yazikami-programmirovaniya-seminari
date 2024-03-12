// Вывести на экран третью слева цифру в числе.

int num = 541231;

if (num > 99)
{
    while (num >= 1000)
    {
        num /= 10;
    }
    
    Console.Write(num % 10);
}
else
{
    Console.Write("Третьей цифры нет");
}