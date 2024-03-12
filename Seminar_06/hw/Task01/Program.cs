// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] letters =
{
{'a', 'b', 'c'},
{'d', 'e', 'f'}
};

string word = "";

foreach (char item in letters)
{
    word += item;
}

Console.WriteLine(word);