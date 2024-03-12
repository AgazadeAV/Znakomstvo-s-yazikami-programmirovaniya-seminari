// Задайте одномерный массив, заполненный случайными числами.
// Определите количество простых чисел в этом массиве.

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
        Console.WriteLine(item + " ");
    }
}

int CountOfPrimeNumbers(int[] arr)
{
    int count = 0;

    foreach (int item in arr)
    {
        if (IsPrime(item))
        {
            count++;
        }
    }

    return count;
}

bool IsPrime(int num)
{
    double limit = Math.Sqrt(num);

    for (int i = 2; i <= limit; i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }

    return true;
}

Console.WriteLine("Input min value:");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value:");
int maximum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input size value:");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(minimum, maximum, length);
ShowArray(array);
int count = CountOfPrimeNumbers(array);
Console.WriteLine($"Count of prime numbers in array is {count}");