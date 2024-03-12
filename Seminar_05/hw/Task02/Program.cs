// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

int[,] SwapFirstLastRows(int[,] array)
{

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int k = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = array[0, i];
        array[0, i] = k;
    }
    
    return array;
}

Console.WriteLine("Введите минимальное значение массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Массив до преображения:");
int[,] matrix = Create2dArray(min, max, rows, cols);
Show2dArray(matrix);
Console.WriteLine("Массив после преображения:");
int[,] swapedMatrix = SwapFirstLastRows(matrix);
Show2dArray(swapedMatrix);
