// Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из массива. Старший разряд
// числа находится на 0-м индексе, младший – на последнем. 

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
        Console.Write(item + " ");
    }

    Console.WriteLine();
}

int NumberFromArray(int[] array)
{
    int number;
    int tenPower = 1;
    int result = 0;

    foreach(int item in array)
    {
        tenPower *= 10;
    }

    for(int i = 0; i < array.Length; i++)
    {
        number = array[i] * tenPower;
        tenPower /= 10;
        result += number;
    }

    result /= 10;
    return result;
}

Console.WriteLine("Input min value:");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value:");
int maximum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input size value:");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(minimum, maximum, length);
ShowArray(array);
int number = NumberFromArray(array);
Console.WriteLine("Целое число, которое состоит из цифр массива:");
Console.WriteLine(number);