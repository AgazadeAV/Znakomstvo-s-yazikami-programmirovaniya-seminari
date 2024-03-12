// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
// Выяснить, сколько среди введённых букв гласных.

bool IsLetterVowels(char vowel)
{
    char[] vowels = ['a','e','i','o','u'];

    foreach(char item in vowels)
    {
        if(vowel == item)
        {
            return true;
        }
    }

    return false;
}

int CountVowelsInArray(string array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(IsLetterVowels(array[i]))
        {
            count++;
        }
    }

    return count;
}

Console.WriteLine("Введите строку:");
string input = Console.ReadLine()!;
Console.WriteLine($"Количество гласных в строке:\n{CountVowelsInArray(input)}");