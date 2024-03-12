// Задайте двумерный массив из целых чисел. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты. Выведите результат на экран.

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

int[,] MakeSquares(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                array[i, j] *= array[i, j];
        }
    }

    return array;
}


int[,] matrix = Create2dArray(1, 9, 3, 3);
Show2dArray(matrix);
Console.WriteLine();
int[,] matrix2 = MakeSquares(matrix);
Show2dArray(matrix2);