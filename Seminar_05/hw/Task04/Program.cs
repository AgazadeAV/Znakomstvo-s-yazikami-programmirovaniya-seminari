// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца.

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

int[] MinElementCoordinates(int[,] array)
{
    int min = array[0, 0];
    int[] min_coordinates = new int[2];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < min)
            {
                min = array[i, j];
                min_coordinates[0] = i;
                min_coordinates[1] = j;
            }
        }
    }

    return min_coordinates;
}

int[,] SwapElementsRow(int[,] array)
{
    for (int i = MinElementCoordinates(array)[0]; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            (array[i + 1, j], array[i, j]) = (array[i, j], array[i + 1, j]);
        }
    }

    return array;
}

int[,] SwapElementsCol(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = MinElementCoordinates(array)[1]; j < array.GetLength(1) - 1; j++)
        {
            (array[i, j + 1], array[i, j]) = (array[i, j], array[i, j + 1]);
        }
    }

    return array;
}

int[,] New2dArray(int[,] array)
{
    int[,] new_array = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for(int i = 0; i < new_array.GetLength(0); i++)
    {
        for(int j = 0; j < new_array.GetLength(1); j++)
        {
            new_array[i,j] = array[i,j];
        }
    }

    return new_array;

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
Console.WriteLine("Массив до преображения:");
Show2dArray(matrix);
Console.WriteLine("Массив после преображения:");
Show2dArray(New2dArray(SwapElementsRow(SwapElementsCol(matrix))));