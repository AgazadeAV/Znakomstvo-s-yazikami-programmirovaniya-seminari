// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size)
{
    Random rnd = new(); // new() = new Random()
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }

    return array;
}

int CountOfEvenElements(int[] arr)
{
    int count = 0;

    foreach (int item in arr)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }

    Console.WriteLine();
}

Console.WriteLine("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(length);
int evenCount = CountOfEvenElements(array);
PrintArray(array); // Для проверки массива
Console.WriteLine(evenCount);