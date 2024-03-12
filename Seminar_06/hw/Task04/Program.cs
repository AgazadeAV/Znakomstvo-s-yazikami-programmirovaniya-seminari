// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string[] SplitString(string input)
{
    string[] answer = new string[CountString(input)];
    int count = 0;
    string result = "";
    
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
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
    for (int i = 0; i < array.Length / 2; i++)
    {
        (array[array.Length - 1 - i], array[i]) = (array[i], array[array.Length - 1 - i]);
    }

    return array;
}

void PrintArray(string[] array)
{
    foreach (string item in array)
    {
        Console.Write($"{item} ");
    }
}

Console.WriteLine("Введите введите предложение");
string sentence = Console.ReadLine()!;
Console.WriteLine("Первёрнутое предложение:");
PrintArray(RevertsSentence(SplitString(sentence)));