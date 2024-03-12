// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет: 
// "Позиция по рядам выходит за пределы массива" или "Позиция по колонкам выходит за пределы массива".

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

int FindElementByPosition(int[,] array, int x, int y)
{
    int number = array[x - 1, y - 1];
    return number;
}

bool ValidatePosition(int[,] array, int x, int y)
{
    bool flag = true;

    if (x > array.GetLength(0) && y > array.GetLength(1))
    {
        flag = false;
    }

    return flag;
}

void PrintResult(int[,] numbers, int x, int y)
{
    if (ValidatePosition(numbers, x, y) == true)
    {
        Console.Write(FindElementByPosition(numbers, x, y));
    }
    else
    {
        Console.Write("Позиция по рядам или колонкам выходит за пределы массива");
    }
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
Console.WriteLine("Введите ккординату по строке:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ккординату по столбцу:");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Элемент по указанным координатам:");
PrintResult(matrix, row, col);