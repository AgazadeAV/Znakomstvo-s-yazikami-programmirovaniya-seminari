// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// Использовать рекурсию. Не использовать цикл.

void PrintNumbers(int num)
{
    if (num == 0)
    {
        return;
    }
    
    PrintNumbers(num - 1);
    Console.Write($"{num} ");
}

PrintNumbers(5);