Console.Clear();


// Сумма цмфр в числе с рекурсией

int SumOfDigits(int num)
{
    if (num == 0)
    {
        return 0;
    }

    int sum = num % 10 + SumOfDigits(num / 10);
    return sum;
}

Console.Clear();
Console.Write(SumOfDigits(654));


// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

void PrintNumbers(int num)
{
    if (num == 0)
    {
        return;
    }
    PrintNumbers(num - 1);

    Console.Write($"{num} ");
}

PrintNumbers(5);


// Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

void GetOnlySoqlasniyelLetters(string letters)
{
    string glasniye = "euioay";

    if (letters.Length < 1)
    {
        return;
    }

    if(char.IsLetter(letters[0]) && !glasniye.Contains(char.ToLower(letters[0])))
    {
        Console.Write($"{letters[0]} ");
    }
    GetOnlySoqlasniyelLetters(letters.Substring(1));
}


string letters = Console.ReadLine()!;
GetOnlySoqlasniyelLetters(letters);

