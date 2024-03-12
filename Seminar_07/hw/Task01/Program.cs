// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void ShowNumbers(int n, int m)
{
    if (n > m)
    {
        return;
    }
    
    Console.Write($"{n} ");
    ShowNumbers(n + 1, m);
}

ShowNumbers(3, 14);