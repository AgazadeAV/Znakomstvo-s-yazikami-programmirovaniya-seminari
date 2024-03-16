// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца.

int[,] array = {
            {5, 3, 2},
            {1, 4, 6},
            {7, 8, 9}
        };

int minElement = int.MaxValue;
int rowToDelete = 0;
int colToDelete = 0;

// Находим наименьший элемент и его индексы
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < minElement)
        {
            minElement = array[i, j];
            rowToDelete = i;
            colToDelete = j;
        }
    }
}

// Создаем новый массив без строки и столбца
int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

for (int i = 0, newRow = 0; i < array.GetLength(0); i++)
{
    if (i == rowToDelete) continue;

    for (int j = 0, newCol = 0; j < array.GetLength(1); j++)
    {
        if (j == colToDelete) continue;

        newArray[newRow, newCol] = array[i, j];
        newCol++;
    }
    newRow++;
}

// Выводим новый массив
for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        Console.Write(newArray[i, j] + " ");
    }
    Console.WriteLine();
}