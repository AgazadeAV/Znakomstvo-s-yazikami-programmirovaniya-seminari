// string s = "";
// char[] chars = ['a', 'b', 'c'];

// foreach (char c in chars){
//     s += c;
// }
// Console.Write(s);

// // На основе символов строки (тип string) сформировать массив символов (тип char[]). 
// // Вывести массив на экран.
// // Указание
// // Метод строки ToCharArray() не использовать.


// char[] ToCharArray(string input)
// {
//     char[] array = new char[input.Length];
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = input[i];
//     }
//     return array;
// }

// // void PrintArray(char[] array)
// // {
// //     foreach (char c in array)
// //     {
// //     Console.Write(c + " ");
// //     }
// //     Console.WriteLine();
// // }

// // int CountGlasniyeInArray(string array)
// // {
// //     int count = 0;
// //     for(int i = 0; i < array.Length; i++)
// //     {
// //         if(array[i] == 'a' || array[i] == 'e' || array[i] == 'o' || array[i] == 'i' || array[i] == 'u')
// //         {
// //             count++;
// //         }
// //     }
// //     return count;
// // }

// // Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
// // Выяснить, сколько среди введённых букв гласных.
// // Пример
// // “hello” => 2
// // “world” => 1

// // bool IsLetterVowels(char vowel)
// // {
// //     char[] vowels = {'a','e','i','o','u'};
// //     foreach(char item in vowels)
// //     {
// //         if(vowel == item)
// //         {
// //             return true;
// //         }
// //     }
// //     return false;

// // }


// // int CountGlasniyeInArray(string array)
// // {
// //     int count = 0;
// //     for(int i = 0; i < array.Length; i++)
// //     {
// //         if(IsLetterVowels(array[i]))
// //         {
// //             count++;
// //         }
// //     }
// //     return count;
// // }

// // string RevertsString(string input)
// // {
// //     string result = "";
// //     for(int i = input.Length - 1; i > -1; i--)
// //     {
// //         result += input[i];
// //     }
// //     return result;
// // }


// // преобразовать строку в массив строк, 
// // разделяя слова пробелами


// // char[] array = ToCharArray(input);
// // Console.WriteLine("Полученный массив:");
// // PrintArray(array);
// // Console.WriteLine($"Количество гласных в строке:\n{CountGlasniyeInArray(input)}");
// // Console.WriteLine($"Перевернутая строка:\n{RevertsString(input)}");

// int CountString(string input)
// {
//     int count = 1;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ' ')
//         {
//             count++;
//         }
//     }
//     return count;


// }

// string[] SplitString(string input)
// {
//     string[] answer = new string[CountString(input)];
//     int count = 0;
//     string result = "";
//     for(int i = 0; i < input.Length; i++)
//     {
//         if(input[i] == ' ')
//         {
//             answer[count] = result;
//             result = "";
//             count++;
//         }
//         else
//         {
//             result += input[i];
//         }

//     }
//     answer[count] = result;
//     return answer;
// }

// void PrintArray(string[] array)
// {
//     foreach (string c in array)
//     {
//     Console.WriteLine(c + " ");
//     }
//     Console.WriteLine();
// }

// // string[] array = SplitString(input);
// // PrintArray(array);

// Console.Clear();
// Console.WriteLine("Введите строку");
// string stroka = Console.ReadLine()!;
// Console.WriteLine("Введите символ");
// char simvol = Console.ReadLine()![0];
// int count = 0;

// foreach(char item in stroka)
// {
//     if(item == simvol)
//     {
//         count++;
//     }
// }


// Console.WriteLine($"Количество {simvol} в {stroka}:");
// Console.WriteLine(count);

// // Ввести строку, ввести символ, вывести массив 
// // целых чисел, с позициями этого символа в строке.



// // Ввести строку, ввести символ, найти, 
// // сколько раз этот символ встречается в строке


Console.Clear();
// char[,] letters = 
// {
//     {'a', 'b', 'c'},
//     {'d', 'e', 'f'}
// };

// string word = "";
// foreach(char item in letters)
// {
//     word += item;
// }

// Console.WriteLine(word);



// char[] FromStringToArray(string input)
// {
//     char[] array = new char[input.Length];
//     for(int i = 0; i < input.Length; i++)
//     {
//         array[i] = input[i];
//     }
//     return array;
// }

// string FromArrayToString(char[] array)
// {
//     string letters = "";
//     foreach(char item in array)
//     {
//         letters += item;
//     }
//     return letters;
// }

// char[] ChangeFromBigToSmall(char[] array)
// {
//     string small = "abcdefghijklmnopqrstuvwxyz";
//     string big = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

//     for(int i = 0; i < array.Length; i++)
//     {
//         bool flag = false;
//         int count = 0;
//         foreach(char item in big)
//         {
//             if(array[i] == item)
//             {
//                 flag = true;
//                 break;
//             }
//             count++;
//         }

//         if(flag)
//         {
//             array[i] = small[count];
//         }
//     }
//     return array;
// }


// // Console.WriteLine("Введите латинские буквы в разных регистрах:");
// // string letters = Console.ReadLine()!;
// // Console.WriteLine(letters);
// // Console.WriteLine("Преобразованная строка:");
// // Console.WriteLine(FromArrayToString(ChangeFromBigToSmall(FromStringToArray(letters))));

// char[] FromStringToArray(string input)
// {
//     char[] array = new char[input.Length];
//     for(int i = 0; i < input.Length; i++)
//     {
//         array[i] = input[i];
//     }
//     return array;
// }

// bool CheckPolyndrom(char[] array)
// {
//     bool flag = false;
//     for(int i = 0; i < array.Length / 2; i++)
//     {
//         if(array[i] == array[array.Length - 1 - i])
//         {
//             flag = true;
//         }
//     }
//     return flag;
// }

// void PrintResult(bool flag)
// {
//     if(flag)
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }

// Console.WriteLine("Введите слово или символы для проверки на полиндромность:");
// string word = Console.ReadLine()!;
// Console.WriteLine("Введённое значение полиндром?");
// PrintResult(CheckPolyndrom(ChangeFromBigToSmall(FromStringToArray(word))));

string[] SplitString(string input)
{
    string[] answer = new string[CountString(input)];
    int count = 0;
    string result = "";
    for(int i = 0; i < input.Length; i++)
    {
        if(input[i] == ' ')
        {
            answer[count] = result;
            result = "";
            count++;
        }
        else
        {
            result += input[i];
        }

    }
    answer[count] = result;
    return answer;
}

int CountString(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            count++;
        }
    }
    return count;
}

string[] RevertsSentence(string[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        (array[array.Length - 1 - i], array[i]) = (array[i], array[array.Length - 1 - i]);
    }
    return array;
}

void PrintArray(string[] array)
{
    foreach(string item in array)
    {
        Console.Write($"{item} ");
    }
}


Console.WriteLine("Введите введите предложение");
string sentence = Console.ReadLine()!;
Console.WriteLine("Первёрнутое предложение:");
PrintArray(RevertsSentence(SplitString(sentence)));