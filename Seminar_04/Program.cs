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