// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] Create2dArray(int min, int max, int rows, int cols)
{
    int[,] array = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }

        Console.WriteLine();
    }
}

int[] SumRows(int[,] array)
{
    int[] arr = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }

        arr[i] = sum;
    }

    return arr;
}

int MinIndex(int[] array)
{
    int min_index = 0;
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            min_index = i;
        }
    }

    return min_index;
}

Console.WriteLine("Введите минимальное значение массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Create2dArray(min, max, rows, cols);
Show2dArray(matrix);
int min_index = MinIndex(SumRows(matrix));
Console.WriteLine($"Строка с наименьшей суммой эдементов:{min_index}");