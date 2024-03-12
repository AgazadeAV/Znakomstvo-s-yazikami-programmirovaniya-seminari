// На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.

char[] ToCharArray(string input)
{
    char[] array = new char[input.Length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = input[i];
    }

    return array;
}

void PrintArray(char[] array)
{
    foreach (char c in array)
    {
        Console.Write(c + " ");
    }
}

string input = "Hello!";
char[] array = ToCharArray(input);
Console.WriteLine("Полученный массив:");
PrintArray(array);