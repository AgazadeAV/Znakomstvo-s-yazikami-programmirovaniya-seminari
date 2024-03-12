// Преобразовать строку в массив строк, разделяя слова пробелами.

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

void PrintArray(string[] array)
{
    foreach (string c in array)
    {
        Console.WriteLine(c + " ");
    }
}

Console.WriteLine("Введите строку:");
string input = Console.ReadLine()!;
string[] array = SplitString(input);
PrintArray(array);