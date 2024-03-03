// int [] CreateRandomArray(int min, int max, int size)
// {
//     int [] array = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     foreach(int item in array)
//     {
//         Console.Write(item + " ");
//     }
// }

// // int CountOfOdd(int[] array)
// // {
// //     int count = 0;
// //     foreach(int item in array)
// //     {
// //         if(item % 2 != 0)
// //         {
// //             count++;
// //         }

// //     }
// //     return count;
// // }

// int CountOfPrimes(int[] arr)
// {
//     int count = 0;

//     return count;
// }

// Console.WriteLine("Input min value:");
// int minimum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value:");
// int maximum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input size value:");
// int length = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(minimum, maximum, length);
// ShowArray(array);
// int count = CountOfOdd(array);
// Console.WriteLine($"Count of odd numbers in array is {count}");

// int [] CreateRandomArray(int min, int max, int size){
//     int [] array = new int [size];
//     for(int i=0; i<size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }

// void ShowArray(int [] array){
//     foreach(int item in array){
//         Console.Write(item+" ");
//     }
// }

// int CountOfPrimes(int [] arr){
//     int count = 0;
//     foreach(int item in arr){
//         if(IsPrime(item)){
//             count++;
//         }
//     }
//     return count;
// }

// bool IsPrime(int num){
//     for(int i = 2; i<num;i++){
//         if (num%i == 0){
//             return false;
//         }
//     }
//     return true;
// }

// // int CountOfOdd(int [] array){
// //     int count = 0;
// //     foreach(int item in array){
// //         if(item%2 != 0){
// //             count++;
// //         }
// //     }
// //     return count;
// // }

// Console.WriteLine("Input min value:");
// int minimum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value:");
// int maximum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input size value:");
// int lenght = Convert.ToInt32(Console.ReadLine());

// // Задайте одномерный массив, заполненный случайными числами. 
// // Определите количество простых чисел в этом массиве.

// // Примеры

// // [1 3 4 19 3] => 2
// // [4 3 4 1 9 5 21 13]  => 3

// int [] array = CreateRandomArray(minimum,maximum,lenght);
// ShowArray(array);
// int count = CountOfPrimes(array);
// Console.WriteLine($" => {count}");
// // int count = CountOfOdd(array);
// // Console.WriteLine($"\nCount of odd numbers in array is {count}");

// Доашнее Задание

// Первое Задание

int GetSumOfDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

bool IsInputDigit(string number)
{
    bool flag = false;
    foreach (char e in number)
    {
        if (char.IsAsciiDigit(e) == true)
        {
            flag = true;
        }
    }
    return flag;
}

Console.WriteLine("Введите целое число для проверки. Чтобы выйти, нажмите 'q'.");
while (true)
{
    string input = Console.ReadLine();
    if (input == "q")
    {
        Console.WriteLine($"Была введена буква {input}.\nПрограмма завершает работу.");
        break;
    }
    else if (IsInputDigit(input))
    {
        int sumOfDigits = GetSumOfDigits(int.Parse(input));
        if (sumOfDigits % 2 == 0)
        {
            Console.WriteLine($"Было введено число {input}, сумма цифр которого чётная.\nПрограмма завершает работу.");
            break;
        }
    }
    else
    {
        Console.WriteLine($"Не было команды завершать работу.\nПрограмма продолжает работу.");
    }
}

// // Второе Задание

// int[] CreateRandomArray(int size)
// {
//     Random rnd = new Random();
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(100, 1000);
//     }
//     return array;
// }

// int CountOfEvenElements(int[] arr)
// {
//     int count = 0;
//     foreach(int item in arr)
//     {
//         if(item%2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// void PrintArray(int[] array)
// {
//     foreach(int item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }


// Console.WriteLine("Введите размер массива:");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(length);
// int count = CountOfEvenElements(array);
// PrintArray(array); //для проверки массива
// Console.WriteLine(count);

// // Третье задание

// int[] CreateRandomArray(int size)
// {
//     Random rnd = new Random();
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.Next(1, 100);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     foreach(int item in arr)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

// int [] GetInvertedArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length / 2; i++)
//     {
//         int k = arr[i];
//         arr[i] = arr[arr.Length - 1 - i];
//         arr[arr.Length - 1 - i] = k;

//     }
//     return arr;
// }

// Console.WriteLine("Введите размер массива:");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(length);
// Console.WriteLine("Изначальный массив:");
// PrintArray(array);
// int[] invertedArray = GetInvertedArray(array);
// Console.WriteLine("Массив после преобразования:");
// PrintArray(invertedArray);

