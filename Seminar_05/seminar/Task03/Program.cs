// Задайте двумерный массив из случайных целых чисел и найдите 
// сумму элементов, находящихся на главной диогонали.

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

int SumOfElementsOnMain(int[,] array)
{
    int sum = 0;
    int count;

    if (array.GetLength(0) < array.GetLength(1))
    {
        count = array.GetLength(0);
    }
    else
    {
        count = array.GetLength(1);
    }

    for (int i = 0; i < count; i++)
    {
        sum += array[i, i];
    }
    
    return sum;
}

int[,] matrix = Create2dArray(1, 9, 3, 3);
Show2dArray(matrix);
int sum = SumOfElementsOnMain(matrix);
Console.WriteLine($"Сумма элементов,находящихся на главной диогонали: {sum}");