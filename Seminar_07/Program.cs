using System.Net.Security;
using System.Security.Cryptography;

Console.Clear();
// int SumOfDigits(int num)
// {
//     if (num == 0)
//     {
//         return 0;
//     }

//     int sum = num % 10 + SumOfDigits(num / 10);
//     return sum;
// }

// Console.Clear();
// Console.Write(SumOfDigits(654));


// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.

// Пример
// N=5 => 1 2 3 4 5

// void PrintNumbers(int num)
// {
//     if (num == 0)
//     {
//         return;
//     }
//     PrintNumbers(num - 1);

//     Console.Write($"{num} ");
// }

// PrintNumbers(5);


// Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d



// void GetOnlySoqlLetters(string letters)
// {
//     string glasniye = "euioay";

//     if (letters.Length < 1)
//     {
//         return;
//     }

//     if(char.IsLetter(letters[0]) && !glasniye.Contains(char.ToLower(letters[0])))
//     {
//         Console.Write($"{letters[0]} ");
//     }
//     GetOnlySoqlLetters(letters.Substring(1));
// }


// string letters = Console.ReadLine()!;
// GetOnlySoqlLetters(letters);

﻿//Задача 3: Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

System.Console.WriteLine("Введите размер массива:");
string input;
int size;
do{
  input  = Console.ReadLine(); 
}
while (!int.TryParse(input, out size));
size = int.Parse(input);

int[] CreateArray (int size){
    int [] array = new int [size];
    Random rand = new Random();

    for (int i = 0; i < size; i++){
        array[i] = rand.Next(1, 100);
    }
    return array;
}

void ShowElements (int[] array){
    if (array.Length == 0)
        return;
    
    System.Console.Write($"{array[array.Length - 1]}\t");
    int[] result = new int[array.Length - 1];
    Array.Copy(array, result, array.Length-1);

    ShowElements(result);
}
int[] ints = CreateArray(size);

foreach (int e in ints){
    System.Console.Write($"{e}\t");
}
System.Console.WriteLine();
ShowElements(ints);