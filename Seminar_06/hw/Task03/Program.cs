// Задайте произвольную строку. Выясните, является ли она палиндромом.

char[] FromStringToArray(string input)
{
    char[] array = new char[input.Length];

    for (int i = 0; i < input.Length; i++)
    {
        array[i] = input[i];
    }

    return array;
}

bool CheckPolyndrom(char[] array)
{
    bool flag = false;

    for (int i = 0; i < array.Length / 2; i++)
    {
        if (array[i] == array[array.Length - 1 - i])
        {
            flag = true;
        }
    }

    return flag;
}

char[] ChangeFromBigToSmall(char[] array)
{
    string small = "abcdefghijklmnopqrstuvwxyz";
    string big = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    for (int i = 0; i < array.Length; i++)
    {
        bool flag = false;
        int count = 0;

        foreach (char item in big)
        {
            if (array[i] == item)
            {
                flag = true;
                break;
            }

            count++;
        }

        if (flag)
        {
            array[i] = small[count];
        }
    }

    return array;
}

void PrintResult(bool flag)
{
    if (flag)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

Console.WriteLine("Введите слово или символы для проверки на полиндромность:");
string word = Console.ReadLine()!;
Console.WriteLine("Введённое значение полиндром?");
PrintResult(CheckPolyndrom(ChangeFromBigToSmall(FromStringToArray(word))));