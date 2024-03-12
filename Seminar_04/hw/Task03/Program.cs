// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

int[] CreateRandomArray(int size)
{
    Random rnd = new();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write($"{item} ");
    }

    Console.WriteLine();
}

int[] GetInvertedArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        (arr[arr.Length - 1 - i], arr[i]) = (arr[i], arr[arr.Length - 1 - i]); // Меняем местами элементы массива
    }

    return arr;
}

Console.WriteLine("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(length);
Console.WriteLine("Изначальный массив:");
PrintArray(array);
int[] invertedArray = GetInvertedArray(array);
Console.WriteLine("Массив после преобразования:");
PrintArray(invertedArray);