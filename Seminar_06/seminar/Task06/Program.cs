// Ввести строку, ввести символ, найти, сколько раз этот символ встречается в строке.

Console.WriteLine("Введите строку:");
string input = Console.ReadLine()!;
Console.WriteLine("Введите символ:");
char element = Console.ReadLine()![0];
int count = 0;

foreach (char item in input)
{
    if (item == element)
    {
        count++;
    }
}

Console.WriteLine($"Количество {element} в {input}:");
Console.WriteLine(count);