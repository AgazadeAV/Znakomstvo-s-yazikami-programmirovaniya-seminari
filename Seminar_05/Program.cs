

// int[,] MakeSquares(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             if (i % 2 == 0 && j % 2 == 0)
//                 array[i,j] *= array[i,j];
//         }
//     }
//     return array;
// }


// int[,] matrix = Create2dArray(1,9,3,3);
// Show2dArray(matrix);
// Console.WriteLine();
// int[,] matrix2 = MakeSquares(matrix);
// Show2dArray(matrix2);

// int Sum (int[,] array){
//     int sum = 0;
//     int count = 0;
//     if(array.GetLength(0)<array.GetLength(1)){
//         count = array.GetLength(0);
//     }
//     else{
//         count = array.GetLength(1);
//     }
//     for (int i = 0; i < count; i++){
//         sum += array[i,i];
//     }
//     return sum;
// }

int[,] Create2dArray(int min, int max, int rows, int cols)
{
    int [,] array = new int[rows,cols];
    for(int i= 0; i<rows;i++)
    {
        for(int j = 0; j<cols; j++)
        {
            array[i,j] = new Random().Next(min,max+1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0;i<array.GetLength(0);i++)
    {
        for(int j = 0;j<array.GetLength(1);j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий из средних арифметических 
// значений по строкам двумерного массива. 



int[] GetArray(int[,] array)
{
    int[] array2 = new int[array.GetLength(0)];
    for(int i = 0; i<array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j<array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        array2[i] = sum / array.GetLength(1);
    }
    return array2;
}


Console.WriteLine("Введите минимальное значение массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrix = Create2dArray(min,max,rows,cols);
Show2dArray(matrix);
int[] array = GetArray(matrix);
Console.WriteLine();

foreach(int item in array)
{
    Console.Write($"{item} ");
}
