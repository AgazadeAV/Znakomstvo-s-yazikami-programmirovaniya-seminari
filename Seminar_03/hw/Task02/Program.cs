// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = [1, 5, 10, 20, 30, 40, 99, 4, 90, 3];
int count = 0;

foreach (int even in array)
{
    if (even % 2 == 0)
    {
        count++;
    }
}

Console.Write(count);