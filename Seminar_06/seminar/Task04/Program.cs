// Считать строку с консоли и перевернуть её задом наперёд.

string RevertsString(string input)
{
    string result = "";
    for (int i = input.Length - 1; i > -1; i--)
    {
        result += input[i];
    }
    return result;
}

Console.WriteLine("Введите строку:");
string input = Console.ReadLine()!;
Console.WriteLine($"Перевернутая строка:\n{RevertsString(input)}");