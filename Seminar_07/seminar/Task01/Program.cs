// Сумма цмфр в числе с рекурсией

int SumOfDigits(int num)
{
    if (num == 0)
    {
        return 0;
    }

    int sum = num % 10 + SumOfDigits(num / 10);
    return sum;
}

Console.Clear();
Console.Write(SumOfDigits(654));