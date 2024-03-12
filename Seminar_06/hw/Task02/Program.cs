// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

char[] FromStringToArray(string input)
{
    char[] array = new char[input.Length];

    for (int i = 0; i < input.Length; i++)
    {
        array[i] = input[i];
    }

    return array;
}

string FromArrayToString(char[] array)
{
    string letters = "";

    foreach (char item in array)
    {
        letters += item;
    }

    return letters;
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

Console.WriteLine("Введите латинские буквы в разных регистрах:");
string letters = Console.ReadLine()!;
Console.WriteLine(letters);
Console.WriteLine("Преобразованная строка:");
Console.WriteLine(FromArrayToString(ChangeFromBigToSmall(FromStringToArray(letters))));