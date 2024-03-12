// Задайте массив символов (тип char []). Создайте строку из символов этого массива.

string s = "";
char[] chars = ['a', 'b', 'c'];

foreach (char c in chars)
{
    s += c;
}

Console.Write(s);