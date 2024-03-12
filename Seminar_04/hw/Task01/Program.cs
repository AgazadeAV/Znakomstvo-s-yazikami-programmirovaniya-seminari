// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

int GetSumOfDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

bool IsInputDigit(string number)
{
    bool flag = false;

    foreach (char e in number)
    {
        if (char.IsAsciiDigit(e) == true)
        {
            flag = true;
        }
    }

    return flag;
}

Console.WriteLine("Введите целое число для проверки. Чтобы выйти, нажмите 'q'.");

while (true)
{
    string input = Console.ReadLine()!;

    if (input == "q")
    {
        Console.WriteLine($"Была введена буква {input}.\nПрограмма завершает работу.");
        break;
    }
    else if (IsInputDigit(input))
    {
        int sumOfDigits = GetSumOfDigits(int.Parse(input));
        
        if (sumOfDigits % 2 == 0)
        {
            Console.WriteLine($"Было введено число {input}, сумма цифр которого чётная.\nПрограмма завершает работу.");
            break;
        }
    }
    else
    {
        Console.WriteLine($"Не было команды завершать работу.\nПрограмма продолжает работу.");
    }
}
