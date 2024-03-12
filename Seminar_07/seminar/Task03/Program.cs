// Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки.

void GetOnlyConsonantlLetters(string letters)
{
    string vowels = "euioay";

    if (letters.Length < 1)
    {
        return;
    }

    if (char.IsLetter(letters[0]) && !vowels.Contains(char.ToLower(letters[0])))
    {
        Console.Write($"{letters[0]} ");
    }

    GetOnlyConsonantlLetters(letters.Substring(1));
}

string letters = Console.ReadLine()!;
GetOnlyConsonantlLetters(letters);