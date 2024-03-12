// Задайте одномерный массив, заполненный случайными числами.
// Посчитать количество нечётных элементов массива.

int[] CreateRandomArray(int min, int max, int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }

    return array;
}

void ShowArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write(item + " ");
    }
}

int CountOfOdd(int[] array)
{
    int count = 0;

    foreach (int item in array)
    {
        if (item % 2 != 0)
        {
            count++;
        }
    }

    return count;
}

Console.WriteLine("Input min value:");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value:");
int maximum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input size value:");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(minimum, maximum, length);
ShowArray(array);
int count = CountOfOdd(array);
Console.WriteLine($"Count of odd numbers in array is {count}");